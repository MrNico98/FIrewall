namespace WinFormsApp1
{
    public partial class Firewall : Form
    {
        public Firewall()
        {
            InitializeComponent();
        }

        private void btnselezionaexe_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable files (*.exe)|*.exe";
            openFileDialog.Title = "Seleziona il file EXE";
            openFileDialog.InitialDirectory = @"C:\Program Files";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
            }
            exeselect.Text = openFileDialog.FileName;
        }

        private void btnapplicafirewall_Click(object sender, EventArgs e)
        {
            string appPath = exeselect.Text;

            if (string.IsNullOrEmpty(appPath) || !System.IO.File.Exists(appPath))
            {
                MessageBox.Show("Seleziona un exe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string appName = "Blocked App - " + System.IO.Path.GetFileNameWithoutExtension(appPath);

            ExecuteNetshCommand($"advfirewall firewall add rule name=\"{appName}\" dir=out action=block program=\"{appPath}\" enable=yes");
            ExecuteNetshCommand($"advfirewall firewall add rule name=\"{appName}\" dir=in action=block program=\"{appPath}\" enable=yes");
        }
        private void ExecuteNetshCommand(string command)
        {
            System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "netsh",
                Arguments = command,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (System.Diagnostics.Process process = System.Diagnostics.Process.Start(processStartInfo))
            {
                process.WaitForExit();
            }
        }


    }
}
