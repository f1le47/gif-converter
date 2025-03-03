using System;
using System.Windows.Forms;
using CourseWorkIT.forms;
using CourseWorkIT.store;
using CourseWorkIT.stores;
using System.Collections.Generic;

namespace CourseWorkIT
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
            Application.Run(new FrameContainer());
        }
    }
}
