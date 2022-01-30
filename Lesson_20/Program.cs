using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_20
{
    class Program
    {
        delegate double MyDelegate(double R);
        static void Main(string[] args)
        {
            MyDelegate length = new MyDelegate(Length);
            length?.Invoke(3.0);
            MyDelegate square = new MyDelegate(Square);
            square?.Invoke(3.0);
            MyDelegate volume = new MyDelegate(Volume);
            volume?.Invoke(3.0);
        }
        static double Length(double R)
        {
            double D = 2 * Math.PI * R;
            return D;
        }
        static double Square(double R)
        {
            double S = Math.PI * R * R;
            return S;
        }
        static double Volume(double R)
        {
            double V = Math.PI * Math.Pow(R, 3.0) * 4 / 3;
            return V;
        }
    }
        

}
