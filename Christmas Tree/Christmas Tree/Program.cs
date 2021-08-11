using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {           
            int height;
            int width;
            int middle;
            int layer;
            bool success;
            var live = true;

            while (live)
            {
                Console.WriteLine("Podaj wysokość choinki :)");
                success = Int32.TryParse(Console.ReadLine(), out height);
                Console.Clear();

                //int animation = 0;
                //bool direction = true;

                //while (true)
                //{
                //    if (direction)
                //    {
                //        animation++;
                //    }
                //    else
                //    {
                //        animation--;
                //    }

                //    Console.Clear();

                    if (success == true)
                    {

                        Console.Write("\n\n\n");
                        middle = height;
                        width = 1;

                        for (layer = 1; layer <= height; layer++)
                        {
                            middle = ToMid(middle);
                           //middle += animation;

                            if (layer == 1)
                            {
                                DrawFirstLayer();
                                width += 2;
                            }
                            else if (layer >= 3 && layer % 2 == 1)
                            {
                                DrawLayer(width);

                                width -= 2;
                                middle += 2;


                                if (layer < height - 2)
                                {
                                 
                                    middle = ToMid(middle);
                                    DrawLayer(width);
                                    width += 2;

                                    middle = ToMid(middle);                                   
                                    DrawLayer(width);
                                    width += 2;

                                    layer += 2;

                                }
                            }
                            else
                            {
                                DrawLayer(width);
                                width += 2;
                            }

                            if (layer == height)
                            {
                                middle = height - 1;
                                ToMid(middle);
                                Console.Write("| |");
                            }

                        }

                        End();
                    }
                    else
                    {
                        Console.WriteLine("Wpisałeś złą warość!\n");

                    }

                    
                    

                    //if (animation >= 1)
                    //{
                    //    direction = false;
                    //}
                    //else if (animation <= -1)
                    //{
                    //    direction = true;
                    //}

                    //Thread.Sleep(200);
                //}
             }

        }

        static public int ToMid(int middle)
        {
            Console.Write("\t\t\t");
            
            for (var i = 1; i <= middle; i++)
            {
                Console.Write(" ");
            }       
            return --middle;
        }

        static public void End()
        {
            Console.WriteLine("\n\n\nKliknij aby kontynuować...");
            Console.ReadLine();
            Console.Clear();
        }

        static public void DrawFirstLayer()
        {
            Console.Write("*\n");           
        }

        static public void DrawLayer(int width)
        {
            for (var i = 1; i <= width; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}
