using System;
using System.Windows;
 
namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            

            int[,] game = new int[4, 4];
            Random rand = new Random();
            int a = rand.Next(2, 4);
            for (int i = 0; i < a; )
            {               
              int  r = rand.Next(0, 4);
              int  t = rand.Next(0, 4);
                if (game[r, t] == 0)
                {
                    game[r, t] = 2;
                    i++;
                }
            }
            int end1 = 1, end2 = 1, end3 = 1, end4 = 1;
            while(true)
            {
                
               
                Console.Clear();
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(game[i, j] + " ");
                        for (int r = 6; r > 0; r--)
                        {
                            if(game[i, j]<Math.Pow(10,r))
                            {
                                Console.Write(" ");
                            }                       
                        }
                    }
                    Console.WriteLine("\n\n\n");
                }
                cki = Console.ReadKey();
                //int l = int.Parse(Console.ReadLine());
                if (cki.Key== ConsoleKey.LeftArrow)
                {
                    end1 = 0;
                    for (int w = 0; w < 4; w++)
                    {
                        int k = 1;

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < k; j++)
                            {
                                if (game[w, k] != 0)
                                {
                                    if (game[w, k - 1] == 0)
                                    {
                                        game[w, k - 1] = game[w, k];
                                        game[w, k] = 0;
                                        k--;
                                        j--;
                                        end1++;

                                    }
                                    else if (game[w, k] == game[w, k - 1])
                                    {
                                        game[w, k] = 0;
                                        game[w, k - 1] *= 2;
                                        k--;
                                        j--;
                                        end1++;

                                    }
                                    
                                }
                               
                            }
                            k++;
                        }
                    }
                }
                else if (cki.Key == ConsoleKey.RightArrow)
                {
                     
                   end2 = 0;
                    
                    for (int w = 0; w < 4; w++)
                    {
                        int k = 2;

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 3; j > k; j--)
                            {
                                if (game[w, k] != 0)
                                {
                                     if (game[w, k + 1] == 0)
                                    {
                                        game[w, k +1] = game[w, k];
                                        game[w, k] = 0;
                                        k++;
                                        j++;
                                        end2++;
                                    }
                                   else if (game[w, k] == game[w, k + 1])
                                    {
                                        game[w, k] = 0;
                                        game[w, k + 1] *= 2;
                                        k++;
                                        j++;
                                        end2++;
                                    }
                                   
                                    
                                }
                               
                            }
                            k--;
                        }
                    }
                }
                else if (cki.Key == ConsoleKey.UpArrow)
                {
                    end3 = 0;

                    for (int w = 0; w < 4; w++)
                    {
                        int o = 1;

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < o; j++)
                            {
                                if (game[o, w] != 0)
                                {
                                    if (game[o, w] == game[o - 1, w])
                                    {
                                        game[o, w] = 0;
                                        game[o - 1, w] *= 2;
                                        o--;
                                        j--;
                                        end3++;
                                    }
                                    else if (game[o - 1, w] == 0)
                                    {
                                        game[o - 1, w] = game[o, w];
                                        game[o, w] = 0;
                                        o--;
                                        j--;
                                        end3++;
                                    }
                                   
                                       
                                    
                                }
                                
                            }
                            o++;
                        }
                    }
                }
                else if(cki.Key == ConsoleKey.DownArrow)
                {
                    end4 = 0;
                    for (int w = 0; w < 4; w++)
                    {
                        int o = 2;

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 3; j > o; j--)
                            {
                                if (game[o, w] != 0)
                                {
                                    if (game[o, w] == game[o + 1, w])
                                    {
                                        game[o, w] = 0;
                                        game[o + 1, w] *= 2;
                                        o++;
                                        j++;
                                        end4++;
                                    }
                                    else if (game[o + 1, w] == 0)
                                    {
                                        game[o + 1, w] = game[o, w];
                                        game[o, w] = 0;
                                        o++;
                                        j++;
                                        end4++;
                                    }
                                    
                                }
                                
                            }
                            o--;
                        }
                    }
                }
                {
                    int r = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j= 0; j < 4; j++)
                        {
                            if(game[i,j]==0)
                            {
                                r++;
                            }
                        }
                    }
                    int q = rand.Next(2, 4);
                    if(q>=r)
                    {
                        q = r;
                    }
                    
                    for (int i = 0; i < q;)
                    {
                        int s = rand.Next(0, 4);
                        int d = rand.Next(0, 4);
                        if (game[s, d] == 0)
                        {
                            game[s, d] = 2;
                            i++;
                        }
                    }
                }
                /*int[,] errorTaZaSho= new int[4, 4];
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if()
                    }
                }*/
                if (end1==0&&end4==0&&end3==0&&end2==0)
                {
                    break;
                }
            }
            Console.WriteLine(" YOU LOSE");
            Console.ReadKey();
        }
    }
       
}
