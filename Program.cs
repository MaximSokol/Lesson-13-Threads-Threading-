using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Lesson_13__Threads_Threading_.Additional_Task;
using Lesson_13__Threads_Threading_.Task_2;
using Lesson_13__Threads_Threading_.Task_3;

namespace Lesson_13__Threads_Threading_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Additional Task

            //var secondary = new SecondaryFlow();
            //ThreadStart start = new ThreadStart(secondary.SecondaryMethod);

            //var th = new Thread(start);
            //th.Start();

            // Task 2

            //GenerateTheChain instance = null;

            //for (int i = 0; i < 30; i++)
            //{
            //    instance = new GenerateTheChain(i * 2);
            //    new Thread(instance.MoveRandomObject).Start();
            //}

            // Task 3

            GenerateRandomSymbolContinue instance = null;

            for (int i = 0; i < 26; i++)
            {
                instance = new GenerateRandomSymbolContinue(i * 3, true);
                new Thread(instance.MoveRandomObject).Start();
            }
        }
    }
}
