using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ccMonitor.Gui;

namespace ccMonitor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            /*TextBox t = new TextBox {Multiline = true, ScrollBars = ScrollBars.Both, Dock = DockStyle.Fill};
            Form f = new Form();
            f.Controls.Add(t);
            try
            {*/
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            Application.Run(new Monitor());
            /*}
            catch (Exception ex)
            {
                t.Text = ex.TargetSite + Environment.NewLine + ex.Data + Environment.NewLine + ex.StackTrace +
                         Environment.NewLine + ex.ToString() + Environment.NewLine + ex.GetType() + Environment.NewLine + 
                         ex.GetBaseException() + Environment.NewLine + ex.InnerException;
                f.Show();
                File.WriteAllText("error.txt", t.Text);
            }*/
            // Convenient debugging ^^"
        }

        static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string dllName = args.Name.Contains(',') ? args.Name.Substring(0, args.Name.IndexOf(',')) : args.Name.Replace(".dll", "");

            dllName = dllName.Replace(".", "_");

            if (dllName.EndsWith("_resources")) return null;

            System.Resources.ResourceManager rm = new System.Resources.ResourceManager("ccMonitor.Properties.Resources", System.Reflection.Assembly.GetExecutingAssembly());

            byte[] bytes = (byte[])rm.GetObject(dllName);

            return System.Reflection.Assembly.Load(bytes);
        }
    }
}
