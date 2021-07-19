using System;

namespace Story
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("What is your name?");
              string name = Console.ReadLine();

              Console.WriteLine("What is your favorite color?");
              string favColor = Console.ReadLine();
              Console.WriteLine("What is your favorite animal?");
              string favAnimal = Console.ReadLine();
              Console.WriteLine("What is your favorite band?");
              string favBand = Console.ReadLine();

              Console.WriteLine($"As {name} was walking hastely to catch the last hour of {favBand}'s reunion show. A big {favColor} {favAnimal} stop him on his way and said,'are you on your way to the {favBand} reunion show?'");

              static int Muiltiply(int num1, int num2)
              {
                  Console.WriteLine(num1 * num2);
                  return num1 * num2;

              }



              static int Add(int num1, int num2)
              {
                  Console.WriteLine(num1 + num2);
                  return num1 + num2;

              }
              static int Subtract(int num1, int num2)
              {
                  Console.WriteLine(num1 - num2);
                  return num1 - num2;

              }

              static int Divide(int num1, int num2)
              {
                  Console.WriteLine(num1 / num2);
                  return num1 / num2;

              }

              Muiltiply(2, 4);
              Add(2, 4);
              Subtract(2, 4);
              Divide(2, 4);
            */

            static int MuiltiplyParams(params int[] list)
            {
                int acc = 1;
      
                foreach(int el in list)
                {
                    acc *= el;
                }
                Console.WriteLine(acc);
                return acc;
            }

            MuiltiplyParams(3, 4, 5, 6, 7, 8);

            static int AddParams(params int[] list)
            {
                int acc = 0;
            
                foreach (int el in list)
                {
                    acc += el;
                }
                Console.WriteLine(acc);
                return acc;
            }

            static int SubParams(params int[] list)
            {
                int acc = list[0] * 2;

                foreach (int el in list)
                {
                    acc -= el;
                }
                Console.WriteLine(acc);
                return acc;
            }

            static double DivideParams(params int[] list)
            {
                int acc = list[0] * list[0];

                foreach (int el in list)
                {
                    acc /= el;
                }
                Console.WriteLine(acc);
                return acc;
            }

            SubParams(3, 4, 5, 6, 7, 8);
        }
    }
}
