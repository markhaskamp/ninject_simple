using System;
using System.Windows.Forms;
using Ninject.Core;

namespace ninjectTemplage
{
    static class Program
    {
        public static  IKernel kernel;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            NinjectSetterUpper module = new NinjectSetterUpper();
            kernel = new StandardKernel(module);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View(kernel));
        }
    }
}
