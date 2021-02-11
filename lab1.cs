/**********************************
*  Выполнил Абраменко Константин  * 
*      Студент группы ПИ-203      *
*              Лаб 1              *
**********************************/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер программы: ");
            int numberOfProgram = Convert.ToInt32(Console.ReadLine());
            switch (numberOfProgram)
            {
                case 1:
                    {
                        Console.Write("Введите число: ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите степень: ");
                        int degree = Convert.ToInt32(Console.ReadLine());
                        int result = 1;
                        
                        for (int i = 0; i < degree; ++i)
                        {
                            result = result * number;
                        }
                        
                        Console.WriteLine(result);
                        Console.ReadKey();
                    }
                break;
                case 2:
                    {
                        Console.Write("Введите число: ");
                        string number = Console.ReadLine();
                        
                        if (number.Length < 3)
                        {
                            Console.WriteLine("Число меньше 100");
                        }
                        else
                        {
                            char firstDigit = number[0];
                            char secondDigit = number[number.Length - 1];
                            Console.Write("Число х = ");
                            Console.Write(firstDigit);
                            Console.Write(secondDigit);
                            
                            for (int i = 1; i < number.Length - 1; ++i)
                            {
                                Console.Write(number[i]);
                            }
                            
                            Console.WriteLine();
                            Console.ReadKey();
                        }
                    }
                break;
            }
        }
    }
}
