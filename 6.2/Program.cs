using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector<double> myVec = new Vector<double>(4.0, 3.0, 0.0);
            Console.WriteLine(myVec.ToString());
            Vector<double> tempVEc = new Vector<double>(0.0, 6.0, 1.0);
            Console.WriteLine(tempVEc.ToString());
            Console.WriteLine("length {0}", myVec.GetLength());
            Console.WriteLine("length {0}", tempVEc.GetLength());
            Console.WriteLine("angle {0}", myVec.GetAngle(tempVEc));
        }
    }
}
