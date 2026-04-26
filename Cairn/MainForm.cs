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
            OpenFileDialog openFileDialog = new()
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
            _peAnalysisService.Analyze(filePath);
        }
    }
}
