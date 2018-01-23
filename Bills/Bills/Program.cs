using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bills
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

            CTCT ct = CTCT.instance;
            if (!ct.ConstructCTCT())
            {
                return;
            }
            CTCT.instance.log.Log("/- - - - - - - - - - Program Start - - - - - - - - - - - -/");
            Application.Run(new Form1());
        }
    }
}
