/*****************************************************************
 * Sample Program showing box of starts and demonstrating colors *
 * Author: Samuel Batchelor                                      *
 * Date 29 February 2024                                         *
 *****************************************************************/


namespace StarsAndDetails
{
    internal class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***************************************");
           
            Console.WriteLine("* Samuel Batchelor                    *");
            Console.WriteLine("* 149 Forfar Street                   *");
            Console.WriteLine("* My favourite BIT Subject is: Maths  *");
            Console.WriteLine("*                                     *");
            Console.WriteLine("***************************************");

            Console.WriteLine(2.3456 + 1);
            Console.Write("what goes\nup \nmust come \tdown\n");
            
            Console.ReadLine();
        }

    }
}
