using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lesson_13__Threads_Threading_.Additional_Task
{
    class SecondaryFlow
    {
        public void SecondaryMethod()
        {
            int index = default;
            while (index < 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("SecondaryFlow");

                Thread.Sleep(500);
                index++;
            }
        }
        //------------------------------------------------
    }
}
