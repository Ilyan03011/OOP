using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyatnashki
{
    class PrintConsole
    {
        public static void PrintTable(int[,] fifteen)
        {
            Console.Clear();
            for (int i = 0; i < fifteen.GetLength(0); i++)
            {
                for (int j = 0; j < fifteen.GetLength(1); j++)
                {
                    Console.Write(fifteen[i,j] + "\t"); 
                }
                Console.WriteLine("\n");
            }

        }

        public static void PrintWarning()
        {
            Console.Write("С каким числом поменять местами нолик? ");
        }

        public static void PrintErrorWarning()
        {
            Console.Write("Ошибка! Введенное число находится далеко от нолика. С каким числом поменять местами нолик? ");
        }

        public static void PrintSize()
        {
            Console.WriteLine("Введите число. Оно будет являться размером игрового поля.");
        }

        public static int EnterTheNumber(int n)
        {
            n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
    }
}
