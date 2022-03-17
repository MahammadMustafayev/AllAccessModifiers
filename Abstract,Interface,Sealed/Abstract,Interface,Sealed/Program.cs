using System;

namespace Abstract_Interface_Sealed
{
    class Program
    {
        static void Main(string[] args)
        {
            Square side = new Square();
            Rectangular width = new Rectangular();
            Rectangular length = new Rectangular();
            int key = 0;  
            do
            {
                Console.WriteLine("Enter the number:");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {  
                    case 1:
                        side.CalcArea();
                        Console.WriteLine("----------------------------");
                        break;
                    case 2:
                        width.CalcArea();
                        length.CalcArea();
                        Console.WriteLine("----------------------------");
                        break;   
                    case 0:
                        Console.WriteLine("Thank You.Good bye");
                        Console.WriteLine("----------------------------");
                        break; 
                    default:
                        Console.WriteLine("You entered incorrectly");
                        break;
                }
            } while (key!=0);
            
           
        }
    }

    // Figure abstract class
    abstract class Figure
    {
        public abstract void CalcArea();
    }

    //Square:Figure class
    class Square:Figure
    {
        public int side 
        {
            get 
            {
                return side;
            }
            set 
            {
                if (value>0)
                {
                    side = value;
                }
                else
                {
                    side = 0;
                }
            } 
        }
        public override void CalcArea()
        {
            Console.WriteLine("Square is figure");
        }
    }

    // Rectangular:Figure class
    class Rectangular:Figure
    {
        public int width 
        {
            get 
            {
                return width;
            }
            set 
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    width = 0;
                }
            }
        }
        public int length 
        {
            get 
            {
                return length;
            }
            set 
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    length = 0;
                }
            } 
        }
        public override void CalcArea()
        {
            Console.WriteLine("Rectangular is figure");
        }
 
    }
}
