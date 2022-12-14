using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lesson_13__Threads_Threading_.Task_2
{
    class GenerateTheChain
    {
        Random rand;
        object block = new object();
        const string litters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        //-----------------------------------------------------------------

        public int Column { get; set; }
        //-----------------------------------------------------------------

        public GenerateTheChain() => this.rand = new Random();

            public GenerateTheChain(int column)
        {
            this.Column = column;
            this.rand = new Random((int)DateTime.Now.Ticks);
        }
        //-----------------------------------------------------------------

        public char GenerateTheSymbol()
        {
            return litters.ToCharArray()[this.rand.Next(0, 35)];
        }
        //--------------------------------------------------

        public void MoveRandomObject()
        {
            int lenght = default(int);
            int count = default(int);
            //------------------------------------
            while(true)
            {
                count = rand.Next(3, 6);
                Thread.Sleep(rand.Next(20, 5000));

                for (int i = 0; i < 40; i++)
                {
                   lock(block)
                   {
                        Console.CursorTop = 0;
                        Console.ForegroundColor = ConsoleColor.Black;

                        for (int j = 0; j < i; j++)
                        {
                            Console.CursorLeft = Column;
                            Console.WriteLine("█");
                        }

                        if (lenght < count)
                            lenght++;
                        else if (lenght == count)
                            count = 0;
                        else if (39 - i < lenght)
                            lenght--;

                        Console.CursorTop = i - lenght + 1;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        for (int j = 0; j < lenght - 2; j++)
                        {
                            Console.CursorLeft = Column;
                            Console.WriteLine(GenerateTheSymbol());
                        }
                        if (lenght >= 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.CursorLeft = Column;
                            Console.WriteLine(GenerateTheSymbol());
                        }
                        if (lenght >= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.CursorLeft = Column;
                            Console.WriteLine(GenerateTheSymbol());
                        }
                        Thread.Sleep(500);
                    }
                }
            }
        }
        //-----------------------------------------------------------------

    }
}
