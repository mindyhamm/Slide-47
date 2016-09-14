using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOOP_Slide_No._47___Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a console application that asks the user for an integer. 
            If that integer is evenly divisible by 3, then write
            “You Won!” If it isn’t, write “You Lost.” 
            Keep asking them for a number (looping) until they win.*/

            //ask use for an integer.
            //IF int is evenly divisable by 3, "you won". if int is divisable by 3, true? break
            //IF it isn't, "you lost". not divisiable by 3, false? continue || try again
            //continue until they win. continue if false?

            //Try while loop || do while?
            //condition is met when "you win" || loop until they win

            //intializer = 0 
            //condition = < 10
            //updater = counter ++

            //intialize and declare variable

            //some condition statement inside parenthesis
            //! equal to 0 then the answer is even

            int userEnterNum;

            while (true)
            {
                Console.WriteLine("Wanna play a game?  Enter a number.");
                userEnterNum = int.Parse(Console.ReadLine());
                if (userEnterNum % 3 != 0)

                    Console.WriteLine("You loose, sorry. Try again.");
                else
                {
                    Console.WriteLine("YOU WIN!");
                    break;
                }

                Console.ReadKey();
            }
        }
    }
}