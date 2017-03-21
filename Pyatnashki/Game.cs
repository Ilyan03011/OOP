using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyatnashki
{
    class Game
    {
        int[,] fifteen;
        int zeroX;
        int zeroY;
        int selectedX = 0;
        int selectedY = 0;


        public Game(int length)
        {
            fifteen = new int[length, length];
            FillArray();
            Randoming(fifteen);
            PrintConsole.PrintTable(fifteen);

            Moving();
        }

        public void FillArray()
        {
            int count = 0;
            for (int i = 0; i < fifteen.GetLength(0); i++)
            {
                for (int j = 0; j < fifteen.GetLength(1); j++)
                {
                    fifteen[i, j] = count;
                    count++;

                    if (fifteen[i, j] == 0)
                    {
                        zeroX = i;
                        zeroY = j;
                    }
                }
            }
        }

        public void Randoming(int[,] fifteen)
        {
            Random Gen = new Random();
            int iran = 0;
            int jran = 0;

            for (int i = 0; i < fifteen.GetLength(0); i++)
            {
                for (int j = 0; j < fifteen.GetLength(1); j++)
                {
                    iran = Gen.Next(0, fifteen.GetLength(0));
                    jran = Gen.Next(0, fifteen.GetLength(1));

                    int temp = fifteen[iran, jran];
                    fifteen[iran, jran] = fifteen[i, j];
                    fifteen[i, j] = temp;

                    if (fifteen[i, j] == 0)
                    {
                        zeroX = i;
                        zeroY = j;
                    }
                }
            }
        }

        public void Moving()
        {
            int selected = 0;

            PrintConsole.PrintWarning();
            selected = PrintConsole.EnterTheNumber(selected);

            while (CheckZero(selected) == false)
            {
                PrintConsole.PrintErrorWarning();
                selected = PrintConsole.EnterTheNumber(selected);
            }

            int temp = fifteen[zeroX, zeroY];
            fifteen[zeroX, zeroY] = fifteen[selectedX, selectedY];
            fifteen[selectedX, selectedY] = temp;

            PrintConsole.PrintTable(fifteen);
            Moving();

        }

        public bool CheckZero(int selected)
        {
            for (int i = 0; i < fifteen.GetLength(0); i++)
            {
                for (int j = 0; j < fifteen.GetLength(1); j++)
                {
                    if (fifteen[i, j] == selected)
                    {
                        selectedX = i;
                        selectedY = j;
                    }
                }
            }

            if (Math.Sqrt(Math.Pow(selectedX - zeroX, 2) + Math.Pow(selectedY - zeroY, 2)) == 1)
            {
                int temp = zeroX;
                int temp2 = zeroY;
                zeroX = selectedX;
                zeroY = selectedY;
                selectedX = temp;
                selectedY = temp2;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
