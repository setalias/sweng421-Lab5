using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    static class COMP
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

            






            IOperationFactory iof = new OperationFactory();
            IOperation newOperation = iof.createOperation("Product");
            Console.WriteLine(newOperation.perform(new Input(2)));

        }

        static void Operation() { }


    }



    


}
