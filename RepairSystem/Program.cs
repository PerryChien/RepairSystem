using System;
using System.Windows.Forms;
using RepairSystem.Forms;

namespace RepairSystem
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 顯示載入畫面
            LoadingForm loadingForm = new LoadingForm();
            Application.Run(loadingForm);
        }
    }
}