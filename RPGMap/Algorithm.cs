using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop
{
    internal static class Algorithm
    {
        [DllImport("back", EntryPoint = "generate")]
        private static extern string generate0(string json);

        [DllImport("back", EntryPoint = "init")]
        private static extern string init0(string path);

        public static Image Generate(string json)
        {
            string resp = string.Empty;

            try
            {
                Image image = Image.FromFile(resp = generate0(json));
                Image clone = new Bitmap(image);
                image.Dispose();
                return clone;
            }
            catch (Exception)
            {
                MessageBox.Show(resp);
                return null;
            }
        }

        public static string Initialize(string path)
        {
            try
            {
                return init0(path);
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
