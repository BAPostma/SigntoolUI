using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace SignToolUI
{
    internal sealed class Signer
    {
        public string SignToolExe { get; set; }
        public string TimeStampServer { get; set; }
        public string CertificatePath { get; set; }
        public string CertificatePassword { get; set; }

        public bool Verbose { get; set; }
        public bool Debug { get; set; }

        public delegate void StatusReport(string message);
        public event StatusReport OnSignToolOutput;

        public Signer(string executable, string certPath, string certPasswrd = null, string timestampServer = null)
        {
            SignToolExe = executable;
            TimeStampServer = timestampServer;
            CertificatePath = certPath;
            CertificatePassword = certPasswrd;
        }

        public void Sign(string targetAssembly)
        {
            //Thread signThread = new Thread(SignAsync);
            //signThread.Start(targetAssembly);

            SignAsync(targetAssembly);
        }

        private void SignAsync(object targetAssembly)
        {
            if (!VerifyFileExists())
            {
                OnSignToolOutput("SignTool.exe can't be found");
                return;
            }

            Process process = new Process();

            process.StartInfo = new ProcessStartInfo(SignToolExe);
            process.StartInfo.Arguments = string.Format(@"sign {0}/tr ""{1}"" /f ""{2}"" /p ""{3}"" /a ""{4}""", GlobalOptionSwitches(), TimeStampServer, CertificatePath, CertificatePassword, targetAssembly);
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            process.OutputDataReceived += (object sender, DataReceivedEventArgs e) => OnSignToolOutput(e.Data);
            process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) => OnSignToolOutput(e.Data);
            process.Exited += (object sender, EventArgs e) => OnSignToolOutput("Exited: " + e.ToString());

            try
            {
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
            }
            catch (Exception ex)
            {
                OnSignToolOutput(ex.Message);
            }
        }

        private string GlobalOptionSwitches()
        {
            if (Verbose && Debug)
            {
                return "/v /debug ";
            }
            else if (Verbose)
            {
                return "/v ";
            }
            else if (Debug)
            {
                return "/debug ";
            }
            else
            {
                return string.Empty;
            }
        }

        private bool VerifyFileExists()
        {
            return File.Exists(SignToolExe);
        }

        public enum SignResult
        {
            Success = 0,
            Failed = 1,
            Warning = 2
        }
    }
}
