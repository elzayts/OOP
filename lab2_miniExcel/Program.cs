using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_excel_lab2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static FormMiniExcel mainFormMiniExcel = new FormMiniExcel();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            // // try
            {
                //       Application.SetCompatibleTextRenderingDefault(false);
            }
            //  catch { };

            Application.Run(mainFormMiniExcel);
        }
    }
}