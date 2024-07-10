using System;
using System.Diagnostics;

namespace PositiveUEFNUtility
{
    public static class PositiveUtility
    {
        /// <summary>
        /// 指定されたURLをデフォルトのブラウザで開きます。
        /// </summary>
        /// <param name="url">開くURL</param>
        public static void OpenUrl(string url)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to open URL: " + ex.Message);
            }
        }
    }
}
