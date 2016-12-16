using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SignToolUI
{
    public static class Helpers
    {
        public static string FindSignToolDirectory()
        {
            string programfiles = Environment.GetFolderPath(Environment.Is64BitOperatingSystem ? Environment.SpecialFolder.ProgramFilesX86 : Environment.SpecialFolder.ProgramFiles);
            string sdkPath = string.Format("{0}\\Microsoft SDKs\\Windows\\", programfiles);
            
            IOrderedEnumerable<string> sdkSubdirectories;
            try
            {
                sdkSubdirectories = Directory.GetDirectories(sdkPath).OrderByDescending(dir => dir); // hihgest version first
            }
            catch (Exception ex)
            {
                return programfiles;
            }

            foreach (string sdkDirectory in sdkSubdirectories)
            {
                string exePath = Path.Combine(sdkDirectory, string.Concat(@"bin\", "signtool.exe"));
                if(File.Exists(exePath)) return Path.Combine(sdkDirectory, @"bin\");
            }

            return programfiles; // if no SDK path found, just return program files
        }
    }
}
