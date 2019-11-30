/*
|-------------------------------------------------------------------------------|
|	This code was written by Srijon Chakraborty								    |
|	Main source code link on https://github.com/srijonchakro			        |
|	All my source codes are available on http://srijon.softallybd.com           |
|	C# Arduino Code Uploader And Serial Read Write		                                            |
|	LinkedIn https://bd.linkedin.com/in/srijon-chakraborty-0ab7aba7				|
|-------------------------------------------------------------------------------|
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
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
            Application.Run(new Form1());
        }
    }
}
