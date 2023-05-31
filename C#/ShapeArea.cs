//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Metadata;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp6
//{
//    class ShapeArea
//    {  
//        static void Main(string[] args)
//        {
//            int length, breadth;
//            string shape = "circle";
//            string again;          
//            do
//            {
//                Console.WriteLine("Enter the shape (Circle, Triangle or Rectangle)");
//                shape = Console.ReadLine().ToLower();
//                Console.WriteLine("The Area is :: {0}", calcArea(shape));

//                Console.WriteLine("Do you want to continue??");
//                again = Console.ReadLine().ToLower();

//            } while (again != "n");
//        }

//        public static double calcArea(string shape)
//        {
            
            
//                if (shape == "circle")
//                {
//                    int? radius = null;
//                    double pi = 3.1415;
//                    Console.WriteLine("Enter the radius of Circle");
//                    try
//                    {
//                        radius = Convert.ToInt32(Console.ReadLine());
//                        return (double)(pi * radius * radius);
//                    }
//                    catch (Exception e)
//                    {
//                        Console.WriteLine(e.Message);
//                        return double.NaN;
//                    }

//                }

//                else if (shape == "rectangle" || shape == "square")
//                {
//                    int? length = null , breadth = null ;
//                    try {
//                        Console.WriteLine("Enter the length of Rectangle");
//                        length = Convert.ToInt32(Console.ReadLine());
//                        Console.WriteLine("Enter the breadth of Rectangle");
//                        breadth = Convert.ToInt32(Console.ReadLine());
//                        return (double)(length * breadth);
//                    }catch(Exception e)
//                    {
//                        Console.WriteLine(e.Message);
//                        return double.NaN;

//                    }

//                }
//                else if (shape == "triangle")
//                {
//                    int? breadth = null, height = null;
//                    try
//                    {
//                        Console.WriteLine("Enter the height of Triangle");
//                        height = Convert.ToInt32(Console.ReadLine());
//                        Console.WriteLine("Enter the breadth of Triangle");
//                        breadth = Convert.ToInt32(Console.ReadLine());
//                        return (double)(height * breadth / 2);
//                    }
//                    catch (Exception e)
//                    {
//                        Console.WriteLine(e.Message);
//                        return double.NaN;
//                    }
//                }
//                else
//                {
//                    return double.NaN;
//                }
//        }
//    }
//}
