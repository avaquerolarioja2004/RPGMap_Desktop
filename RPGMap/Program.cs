using desktop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGMap
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            string resp = Algorithm.Initialize(Directory.GetCurrentDirectory());

            if(resp != string.Empty)
            {
                MessageBox.Show(resp, "ERROR");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RPGMap());
        }
    }
}
