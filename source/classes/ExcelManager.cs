using System;
using System.IO;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SpecificationBuilder
{
    public class ExcelManager
    {
        private Logger logger;
        private MainForm mainForm;
        private Excel.Application excelApp;

        public ExcelManager(MainForm form, Panel progressPanel, Logger logger)
        {
            mainForm = form;
            excelApp = new Excel.Application()
            {
                Visible = false,
                DisplayAlerts = false,
                ScreenUpdating = false,
            };

            if (excelApp == null)
            {
                logger.AppendToLog("Excel не установлен. Дальнейшая работа невозможна.", LogLevel.Error);
                return;
            }

            this.logger = logger;
        }

        public DataTable LoadFile(string filename, int page, Panel progressPanel, int c1, int r1, int c2 = -1, int r2 = -1)
        {
            DataTable importTable = new DataTable();

            Excel.Workbook book = excelApp.Workbooks.Open(filename, true, true, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, false, false, Missing.Value, false, false, false);
            Excel.Worksheet sheet;

            if (page > 0)
                sheet = excelApp.Sheets[page];
            else
                sheet = excelApp.Sheets[1];

            Excel.Range range = sheet.UsedRange;

            if (c2 == -1)
                c2 = range.Columns.Count;
            if (r2 == -1)
                r2 = range.Rows.Count;

            Excel.Range start = (Excel.Range)sheet.Cells[r1, c1];
            Excel.Range end = (Excel.Range)sheet.Cells[r2, c2];

            range = sheet.get_Range(start, end);

            ProgressViewer progressViewer = new ProgressViewer(range.Rows.Count, progressPanel);

            progressViewer.StartProgress();

            importTable.TableName = sheet.Name.ToString();

            while (importTable.Columns.Count < range.Columns.Count)
                importTable.Columns.Add();

            object[,] arr = new object[range.Rows.Count, range.Columns.Count];
            arr = range.Value;

            int i;
            int j;
            DataRow dr;

            i = 1;
            while (i <= arr.GetLength(0))
            {
                dr = importTable.NewRow();
                j = 1;
                while (j <= arr.GetLength(1))
                {
                    dr[j - 1] = arr[i, j];
                    j++;
                }
                importTable.Rows.Add(dr);
                progressViewer.MakeProgress();
                i++;
            }

            progressViewer.StopProgress();

            logger.AppendToLog("Файл " + System.IO.Path.GetFileName(filename) + " загружен за " + progressViewer.Finish() + " секунд.");
            mainForm.RemoveProgress(progressViewer);

            book.Close(0);

            releaseObject(arr);
            releaseObject(range);
            releaseObject(sheet);
            return importTable;
        }

        public void WriteRow(int row, int startColumn, Excel.Worksheet sheet, string[] arr)
        {
            var data = new object[1, arr.Length];

            int column;

            column = 0;
            while (column < arr.Length)
            {
                data[0, column] = arr[column];
                column++;
            }

            var startCell = (Excel.Range)sheet.Cells[row, startColumn];
            var endCell = (Excel.Range)sheet.Cells[row, startColumn + column - 1];
            var writeRange = sheet.Range[startCell, endCell];

            writeRange.Value = data;
        }

        public int GetPagesCount(string filename)
        {
            int pagesCount = -1;
            try
            {
                Excel.Workbook book = excelApp.Workbooks.Open(filename.Replace("/", "_"), true, true, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, false, false, Missing.Value, false, true, false);
                Excel.Worksheet sheet = book.Sheets[1];

                pagesCount = sheet.PageSetup.Pages.Count;

                book.Close(0);
            }
            catch
            {
                logger.AppendToLog("Не удалось получить количество страниц документа " + Path.GetFileNameWithoutExtension(filename));
            }
            return pagesCount;
        }

        public void Quit()
        {
            if (excelApp != null)
                excelApp.Quit();

            releaseObject(excelApp);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
