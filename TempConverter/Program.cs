using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConverter
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        /*

        Author: <Yagna Sri Vintha>

        Program Title: <CSC 317 Object Oriented Programming - TempConverter.>

        File Description:
        Program takes input and the format and converts the value into respective values in other temperature formats
        This helps in :
        Identifying the test cases 
        limitations of the Data Types 
        using the resources

        */
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
