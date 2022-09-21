// See https://aka.ms/new-console-template for more informatio

using System.Data;
using System.Drawing;
namespace snake;
class Program
{
    static void Main(string[] args)
    {   point p1 = new point(1, 3, '@');
        p1.Draw();
        point p2 = new point(4, 5, '@');
        p2.Draw();
        point p3 = new point(5, 7, '@');
        p3.Draw();
        List<point> pList = new List<point>();
        pList.Add (p1);
        pList.Add (p2);
        pList.Add (p3);

        Console.ReadLine();
    }
}
