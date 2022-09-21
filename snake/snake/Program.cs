// See https://aka.ms/new-console-template for more informatio

using System.Drawing;
namespace snake;
class Program
{
    static void Main(string[] args)
    {   point p1 = new point();
        p1.X = 1;
        p1.Y = 3;
        p1.sym = '@';
        p1.Draw();

        point p2 = new point();
        p2.X = 4;
        p2.Y = 5;
        p2.sym = '@';
        p2.Draw();
        Console.ReadLine();
    }
}

