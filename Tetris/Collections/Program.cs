using System;
using Tetris;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            

            Point[] points = new Point[3];
            points[0] = new Point(1, 2, '*');
            points[1] = new Point(3, 4, '#');
            points[2] = new Point(5, 6, '*');

            foreach (Point p in points)
            {
                p.Draw();
            }
            
            
            
            
            
            Console.ReadLine();
        }

       
    }
}
