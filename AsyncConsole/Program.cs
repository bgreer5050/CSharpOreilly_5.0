using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace AsyncConsole
{
    //Define a Type.  This is like defining a class type, but for methods
    delegate void DisplayMessage(string message);

    class Program
    {
        static void Main(string[] args)
        {

            DisplayMessage messageTarget; //messageTarget is a variable of Type DisplayMessage
            messageTarget = ShowMessage; //messageTarget is instantiated now and will call ShowMessage when invoked.

            messageTarget("Message"); //messageTarget is invoked


            while(true)
            {

            }
        }

        private static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
