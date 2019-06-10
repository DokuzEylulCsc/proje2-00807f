using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ///test boyz   
            SystemControl.Otellist.Add(new ButikOtel());
            SystemControl.Otellist.Add(new Pansiyon());
            SystemControl.Otellist.Add(new TatilKoyu());
            SystemControl.Userlist.Add(new musteri());
            //FileOp.filewrite();



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
