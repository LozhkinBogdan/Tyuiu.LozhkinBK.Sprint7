using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LozhkinBK.Sprint7.Project.V14.Forms;

namespace Tyuiu.LozhkinBK.Sprint7.Project.V14
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain_LBK());
        }
    }
}
