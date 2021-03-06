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

        public void Dpattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 && j >= 1 && j <= 4 || i == 5 && j >= 1 && j <= 4 || j == 5 && i >= 2 && i <= 4 || j == 2)
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
        public void Epattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if(i == 1 && j >= 2 && j <= 5 || i == 5 && j >= 2 && j <= 5 || i == 3 && j >= 2 && j <= 5 || j == 1 && i >= 2 && i <= 4)
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
        public void Fpattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 || i == 3 && j<=4|| j == 1)
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
        public void Gpattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 && j >= 2 && j <= 5 || i == 5 && j >= 2 && j <= 5 || j == 1 && i >= 2 && i <= 4 || i == 3 && j >= 3 || j == 5 && i >= 3)
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
        public void Hpattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i ==3||j==1||j==5)
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
        public void Ipattern()
        {
            for(int i = 1;i <= 5; i++)
            {
                for(int j = 1; j<= 5; j++)
                {
                    if(i==1||i==5||j==3)
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
        public void Jpattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 && j >= 3 || j == 4 || i == 5 && j <= 3 || j == 1 && i >= 3)
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
        public void Kpattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j == 1 || i + j == 5 || i - j == 1)
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
        public void Lpattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j == 1 || i==5)
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
        public void Mpattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    if (j == 1 || j == 7 || i==2 && j >= 3 && j <=3 || i==3 && j >= 4 && j<= 4 || i==2 && j>=5 && j<=5)
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
        public void Npattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                  if(j == 1 || j == 6 || i - j == 0)
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
        public void Opattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++) 
                {
                    if (i == 1 && j >= 2 && j <= 4 || i == 5 && j >= 2 && j <= 4 || j == 1 && i >= 2 && i <= 4 || j == 5 && i >= 2 && i <= 4)
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
        public void Ppattern()
        {
            for(int i = 1; i <=5; i++)
            {
                for(int j = 1; j <=5; j++)
                {
                    if(j==1 ||j==5 &&i<=3 || i==1 && j>=2 && j<=4 || i==3 && j>=2 && j<=4)
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
        public void Qpattern()
        { 
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    if ((j == 1 || j == 5) && i >=2 && i<=4 || (i == 1 || i==5) && j >= 2 && j <=4 ||( i==4 || i==5 || i==6 )&& i==j)
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
        public void Rpattern()
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    if (j == 1 || (i == 1 || i == 3) && j < 5 || (j == 5 && i > 1 && i < 3) || j == i - 1)
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
        public void Spattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if(i==1 && j>=2 && j<=5 || i == 3 && j >= 2 && j <= 4 || i == 5 && j <= 4 || j==1 && i>=2 && i<=3 || j==5 && i>=3 && i<=4)
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
        public void Tpattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i==1 || j==3)
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
        public void Upattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if ( j == 1 && i >= 2 && i <= 4 || j == 5 && i >= 2 && i <= 4 || i == 5 && j >= 2 && j <= 4 )
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
        public void Vpattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if(i==j||i+j==10)
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
        public void Wpattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j==1 || j==5 ||i - j == 0 && j >= 4 && j <= 4 || i + j == 6 && j >= 2 && j <= 3)
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
        public void Xpattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i==j || i+j==6)
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
        public void Ypattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if ((i == j && j < 4) || (i + j == 6 && i < 4) || j == 3 && i > 3)
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
        public void Zpattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 || i == 5 || i + j == 6)
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
