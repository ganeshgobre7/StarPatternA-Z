using System;
using System.Collections.Generic;
using System.Text;

namespace StarPatternA_Z
{
    class StarPattern
    {
        public void Apattern()
        {
            for (int i = 1; i <= 5; i++)//for rows
            {
                for (int j = 1; j <= 5; j++)//for columns
                {
                    if (i == 1 && j >= 2 && j <= 4 || i == 3 && j >= 2 && j <= 4 ||
                        j == 1 && i >= 2 && i <= 4 || j == 5 && i >= 2 && i <= 4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void Cpattern()
        {
            for (int i = 1; i <= 5; i++)//for rows
            {
                for (int j = 1; j <= 5; j++)//for columns
                {
                    //if (i==1 || i==6 ||j==1)
                    if (i == 1 && j >= 2 && j <= 5 || i == 5 && j >= 2 && j <= 5 || j == 1 && i >= 2 && i <= 4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }       
    }
}
