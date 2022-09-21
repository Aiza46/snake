// See https://aka.ms/new-console-template for more informatio

using System.Drawing;
namespace snake;
class Program
{
    static void Main(string[] args)
    {   point p1 = new point(1, 3, '$');
        p1.Draw();

        point p2 = new point(4,5,'$');
        p2.Draw();
        Console.ReadLine();
    }
}

