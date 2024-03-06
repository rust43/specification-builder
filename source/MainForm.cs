using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace SpecificationBuilder
{
    public partial class MainForm : Form
    {
        Logger logger;

        private ExcelManager excel;

        private List<ProgressViewer> progressViewers;

        ClassificatorFile classificatorFile;

        List<string> fasteningNames;
        List<string> supportNames;
        List<string> couplingNames;
        List<string> crossNames;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            logger = new Logger(journal);

            if (logger != null)
                logger.AppendToLog("Начало работы", LogLevel.Usual);

            progressViewers = new List<ProgressViewer>();

            pnlProgressBar.Width = 0;

            excel = new ExcelManager(this, pnlProgress, logger);

            fasteningNames = new List<string>();
            supportNames = new List<string>();
            couplingNames = new List<string>();
            crossNames = new List<string>();

            string classificator_filename = AppDomain.CurrentDomain.BaseDirectory + "classificator.xlsx";

            if (File.Exists(classificator_filename))
            {
                logger.AppendToLog("Обнаружен файл классификатора в папке с программой.");
                LoadClassificatorFile(classificator_filename);
            }
        }

        private static Panel CreatePanel(string[] names = null)
        {
            var lblVar = new Label()
            {
                AutoSize = true,
                Location = new Point(3, 3),
                Size = new Size(56, 17),
                Text = "Вариант",
            };

            var cmbVar = new ComboBox()
            {
                Anchor = ((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right),
                DropDownStyle = ComboBoxStyle.DropDownList,
                FormattingEnabled = true,
                Location = new Point(3, 23),
                Size = new Size(121, 25),
                TabIndex = 0,
            };

            if (names != null)
            {
                cmbVar.Items.AddRange(names);
            }

            var lblCount = new Label()
            {
                Anchor = (AnchorStyles.Top | AnchorStyles.Right),
                AutoSize = true,
                Location = new Point(127, 3),
                Size = new Size(27, 17),
                Text = "шт.",
            };

            var txtCount = new TextBox()
            {
                Anchor = (AnchorStyles.Top | AnchorStyles.Right),
                Location = new Point(130, 23),
                Size = new Size(52, 25),
                Text = "0",
            };

            var panel = new Panel()
            {
                Dock = DockStyle.Top,
                Location = new Point(3, 18),
                Margin = new Padding(0),
                Size = new Size(185, 60),
            };

            var delete_btn = new Button()
            {
                Anchor = (AnchorStyles.Top | AnchorStyles.Right),
                Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                Location = new Point(162, 2),
                Margin = new Padding(0),
                Name = "btnDel",
                Size = new Size(20, 20),
                TabIndex = 4,
                Text = "X",
                UseVisualStyleBackColor = true,
            };

            panel.Controls.Add(lblVar);
            panel.Controls.Add(cmbVar);
            panel.Controls.Add(lblCount);
            panel.Controls.Add(txtCount);
            panel.Controls.Add(delete_btn);

            delete_btn.Click += Delete_btn_Click;

            return panel;
        }

        private static void Delete_btn_Click(object sender, EventArgs e)
        {
            var panel = ((Button)sender).Parent;
            var table = ((Panel)panel).Parent;
            table.Controls.Remove(panel);
        }

        private void Create_Fastening_Panel()
        {
            var panel = CreatePanel(fasteningNames.ToArray());
            grpFastening.Controls.Add(panel);
            grpFastening.Controls.SetChildIndex(panel, 1);
        }

        private void Clear_Fastening_Panel()
        {
            while (grpFastening.Controls.Count > 1)
                grpFastening.Controls.RemoveAt(grpFastening.Controls.Count - 1);
        }

        private void Create_Support_Panel()
        {
            var panel = CreatePanel(supportNames.ToArray());
            grpSup.Controls.Add(panel);
            grpSup.Controls.SetChildIndex(panel, 1);
        }

        private void Clear_Support_Panel()
        {
            while (grpSup.Controls.Count > 1)
                grpSup.Controls.RemoveAt(grpSup.Controls.Count - 1);
        }

        private void Create_Coupling_Panel()
        {
            var panel = CreatePanel(couplingNames.ToArray());
            grpCoup.Controls.Add(panel);
            grpCoup.Controls.SetChildIndex(panel, 1);
        }

        private void Clear_Coupling_Panel()
        {
            while (grpCoup.Controls.Count > 1)
                grpCoup.Controls.RemoveAt(grpCoup.Controls.Count - 1);
        }

        private void Create_Cross_Panel()
        {
            var panel = CreatePanel(crossNames.ToArray());
            grpCross.Controls.Add(panel);
            grpCross.Controls.SetChildIndex(panel, 1);
        }

        private void Clear_Cross_Panel()
        {
            while (grpCross.Controls.Count > 1)
                grpCross.Controls.RemoveAt(grpCross.Controls.Count - 1);
        }

        private void chkBtnAddFastening_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkBtnAddFastening.Checked) return;
            Create_Fastening_Panel();
            chkBtnAddFastening.Checked = false;
        }

        private void chkBtnAddSup_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkBtnAddSup.Checked) return;
            Create_Support_Panel();
            chkBtnAddSup.Checked = false;
        }

        private void chkBtnAddCoup_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkBtnAddCoup.Checked) return;
            Create_Coupling_Panel();
            chkBtnAddCoup.Checked = false;
        }

        private void chkBtnAddCross_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkBtnAddCross.Checked) return;
            Create_Cross_Panel();
            chkBtnAddCross.Checked = false;
        }
        public void AddProgress(ProgressViewer viewer)
        {
            progressViewers.Add(viewer);
        }

        public void RemoveProgress(ProgressViewer viewer)
        {
            progressViewers.Remove(viewer);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (progressViewers.Count > 0)
                foreach (ProgressViewer progressViewer in progressViewers)
                    progressViewer.ProgressBarResized();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadClassificatorFile(openFileDialog.FileName);
            }
        }

        private void LoadClassificatorFile(string filename)
        {
            classificatorFile = new ClassificatorFile(excel, logger, filename);
            classificatorFile.LoadFile(pnlProgress);
            FillLoadedData();
        }

        private void FillLoadedData()
        {
            Clear_Fastening_Panel();
            Clear_Support_Panel();
            Clear_Coupling_Panel();
            Clear_Cross_Panel();

            fasteningNames.Clear();
            supportNames.Clear();
            couplingNames.Clear();
            crossNames.Clear();

            foreach (var variant in classificatorFile.GetSpecificationVariants())
            {
                var type = variant.GetVariant;

                if (type == VariantType.Fastening)
                    fasteningNames.Add(variant.GetName);

                if (type == VariantType.SupportingFastening)
                    supportNames.Add(variant.GetName);

                if (type == VariantType.Coupling)
                    couplingNames.Add(variant.GetName);

                if (type == VariantType.Cross)
                    crossNames.Add(variant.GetName);
            }

            Create_Fastening_Panel();
            Create_Support_Panel();
            Create_Coupling_Panel();
            Create_Cross_Panel();
        }

        private object[] CollectFormData()
        {
            var selected_fastenings = new Dictionary<string, int>();
            var selected_supports = new Dictionary<string, int>();
            var selected_couplings = new Dictionary<string, int>();
            var selected_crosses = new Dictionary<string, int>();

            if (grpFastening.Controls.Count > 1)
            {
                for (int i = 1; i < grpFastening.Controls.Count; i++)
                {
                    var panel = (Panel)grpFastening.Controls[i];
                    var cmbVariant = (ComboBox)panel.Controls[1];
                    var txtCount = (TextBox)panel.Controls[3];

                    if (cmbVariant.SelectedItem == null) continue;

                    string variant = cmbVariant.SelectedItem.ToString();
                    int.TryParse(txtCount.Text, out int count);

                    selected_fastenings[variant] = count;
                }
            }

            if (grpSup.Controls.Count > 1)
            {
                for (int i = 1; i < grpSup.Controls.Count; i++)
                {
                    var panel = (Panel)grpSup.Controls[i];
                    var cmbVariant = (ComboBox)panel.Controls[1];
                    var txtCount = (TextBox)panel.Controls[3];

                    if (cmbVariant.SelectedItem == null) continue;

                    string variant = cmbVariant.SelectedItem.ToString();
                    int.TryParse(txtCount.Text, out int count);

                    selected_supports[variant] = count;
                }
            }

            if (grpCoup.Controls.Count > 1)
            {
                for (int i = 1; i < grpCoup.Controls.Count; i++)
                {
                    var panel = (Panel)grpCoup.Controls[i];
                    var cmbVariant = (ComboBox)panel.Controls[1];
                    var txtCount = (TextBox)panel.Controls[3];

                    if (cmbVariant.SelectedItem == null) continue;

                    string variant = cmbVariant.SelectedItem.ToString();
                    int.TryParse(txtCount.Text, out int count);

                    selected_couplings[variant] = count;
                }
            }

            if (grpCross.Controls.Count > 1)
            {
                for (int i = 1; i < grpCross.Controls.Count; i++)
                {
                    var panel = (Panel)grpCross.Controls[i];
                    var cmbVariant = (ComboBox)panel.Controls[1];
                    var txtCount = (TextBox)panel.Controls[3];

                    if (cmbVariant.SelectedItem == null) continue;

                    string variant = cmbVariant.SelectedItem.ToString();
                    int.TryParse(txtCount.Text, out int count);

                    selected_crosses[variant] = count;
                }
            }

            object[] data = new object[]
            {
                selected_fastenings,
                selected_supports,
                selected_couplings,
                selected_crosses
            };

            return data;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            excel.Quit();
        }

        private void btnBuildSpecification_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Таблица Excel|*.xlsx|Все файлы|*.*";
            saveFileDialog.Title = "Выберите путь сохранения спецификации";
            saveFileDialog.DefaultExt = ".xlsx";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "спецификация";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var data = CollectFormData();
                //SaveSpecificationFile(data);
            }
        }

        private void btnCollectDrawingSet_Click(object sender, EventArgs e)
        {

        }
    }
}

