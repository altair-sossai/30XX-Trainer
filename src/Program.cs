using System;
using System.Windows.Forms;

namespace _30XX_Trainer
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmTrainer());
        }
    }
}