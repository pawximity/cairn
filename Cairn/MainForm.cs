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
            architectureValueLabel.Text = peAnalysisResult.Is64Bit ? "64 Bit" : "32 Bit";
            entryPointValueLabel.Text = Convert.ToString(peAnalysisResult.AddressOfEntryPoint);
            peDataGridView.DataSource = peAnalysisResult.SectionResults.ToList();
        }
    }
}
