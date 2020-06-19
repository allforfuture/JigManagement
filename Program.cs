using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JigManagement
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DialogResult dr = new Login().ShowDialog();
            if (dr == DialogResult.OK)
            {
                Config.Control.GetReasonValue();
                Application.Run(new JigManagement());
            }
        }
    }
}
