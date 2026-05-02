using cairn.Models;
using cairn.Services;
using System.Windows.Forms.Design;

namespace cairn
{
    public partial class MainForm : Form
    {

        private readonly PeAnalysisService _peAnalysisService;

        public MainForm(PeAnalysisService peAnalysisService)
        {
            InitializeComponent();
            _peAnalysisService = peAnalysisService;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Executables (*.exe;*.dll)|*.exe;*.dll|All files (*.*)|*.*"
            };

            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult != DialogResult.OK)
            {
                return;
            }
            string filePath = openFileDialog.FileName;
            filePathTextbox.Text = filePath;
            OpenPeFile(filePath);
        }

        private void OpenPeFile(string filePath)
        {
            PeAnalysisResult? analysisResult = _peAnalysisService.Analyze(filePath);
            RenderPeAnalysisResult(analysisResult);
        }

        private void RenderPeAnalysisResult(PeAnalysisResult? peAnalysisResult)
        {
            if (peAnalysisResult == null)
            {
                return;
            }
            formatValueLabel.Text = peAnalysisResult.Format;
            machineValueLabel.Text = peAnalysisResult.Machine;
            entryPointValueLabel.Text = Convert.ToString(peAnalysisResult.AddressOfEntryPointHex);
            memoryFootprintValueLabel.Text = FormatBytes(peAnalysisResult.ImageSize);
            fileSizeValueLabel.Text = FormatBytes(peAnalysisResult.FileSize);
            dataGridView.DataSource = peAnalysisResult.SectionResults.ToList();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private static string FormatBytes(long bytes)
        {
            if (bytes < 1024)
            {
                return $"{bytes} B";
            }
            if (bytes < 1024 * 1024)
            {
                return $"{bytes / 1024.0:F2} KB";
            }
            return $"{bytes / 1024.0 / 1024.0:F2} MB";
        }
    }
}
