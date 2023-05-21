using System.Diagnostics;

namespace PageOpener
{
    public partial class Opener : Form
    {
        public Opener()
        {
            InitializeComponent();
        }

        private string? currentUrl;
        private bool loopUrl = true;
        Process[] allProcesses = Process.GetProcesses();

        private void OpenUrl(string url)
        {
            // Save the current URL
            currentUrl = url;

            // Open the URL in the default system browser
            System.Diagnostics.Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void Wait(int seconds)
        {
            // Wait for the selected time span
            System.Threading.Thread.Sleep(seconds * 1000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the URL from the text box
            string url = urlTextBox.Text;

            while (loopUrl)
            {
                OpenUrl(url);
                Wait((int)timeSpanNumericUpDown.Value);
                foreach (var process in allProcesses)
                {
                    if (process.MainWindowTitle != "")
                    {
                        string s = process.ProcessName.ToLower();
                        if (s == "chrome" || s == "firefox")      //needs a better way to close browser window
                            process.Kill();
                    }
                }
                System.Threading.Thread.Sleep(3000);
            }
        }

        private void Opener_Load(object sender, EventArgs e)
        {

        }

        private void urlTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

