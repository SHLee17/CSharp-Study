using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch08
{
    class Box
    {
        int width;
        int height;
        public int Width { get => width; 
            set
            {
                if (value > 0) width = value;
                else throw new Exception("너비는 0보다 커야 합니다.");
            }
        
        }
        public int Height { 
            get => height; 
            set 
            {
                if (value > 0) height = value;
                else throw new Exception("높이는 0보다 커야 합니다.");
            } 
        }

        public Box(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public void Area()
        {
            Console.WriteLine("Box 넓이 : " + width * height);
        }

    }
    internal class _2_Throw
    {
        static void Main1(string[] args)
        {

            try
            {
                Box box1 = new Box(10, 10);
                box1.Area();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
