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
            pansfactory pfac = new pansfactory();
            butfactory bfac = new butfactory();
            koyfactory kfac = new koyfactory();
            
            SystemControl.Otellist.Add(pfac.GetOtel("izmir", "testotel", 2));
            SystemControl.Otellist.Add(bfac.GetOtel("sivas", "patates", 1));
            SystemControl.Otellist.Add(kfac.GetOtel("ankara", "testkoy", 4));
            SystemControl.Userlist.Add(new admin("admin","admin"));
            SystemControl.Userlist.Add(new musteri("aykirimahmut42","12313131","mahmut","mahmutoglu","hunter2"));
            SystemControl.Userlist.Add(new musteri("CcCg£zgInBoyCcC", "31312312", "Ahmet", "patatesson", "password"));
            FileOp.filewrite();
            FileOp.fileread();

            OtelAggregate testaggre = new OtelAggregate();
            foreach(otel z in SystemControl.Otellist)
            {
                testaggre.Add(z);
            }

            IIterator testiter = testaggre.CreateIterator();

            while (testiter.HasItem())
            {
                Console.WriteLine(testiter.CurrentItem().Otelname);
                testiter.NextItem();
            }


            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmgiris());
        }
    }
}
