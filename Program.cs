using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace SwaggerTokens
{
    internal static class Program
    {
        private static string m_TokenAmountPath = "TokenAmount.txt";
        private static string m_TokenHistoryPath = "TokenHistory.txt";


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Check for files.
            if (!File.Exists(m_TokenAmountPath))
            {
                var amtFile = File.CreateText(m_TokenAmountPath);
                amtFile.Write("0");
                amtFile.Close();

            }

            if (!File.Exists(m_TokenHistoryPath))
            {
                var histFile = File.CreateText(m_TokenHistoryPath);
                histFile.WriteLine($"Start of History\n");
                histFile.Close();
            }


            Application.Run(new SwaggerTokens(m_TokenAmountPath, m_TokenHistoryPath));
        }
    }
}
