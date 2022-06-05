using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    public class Vector<T> where T : struct
    {
        public T A { get; set; }

        public T B { get; set; }

        public T C { get; set; }

        public Vector()
        {
            this.A = default(T);
            this.B = default(T);
            this.C = default(T);
        }

        public Vector(T _a, T _b, T _c)
        {
            this.A = _a;
            this.B = _b;
            this.C = _c;
        }

        public Vector(Vector<T> temp)
        {
            this.A = temp.A;
            this.B = temp.B;
            this.C = temp.C;
        }

        public override string ToString()
        {
            return "a = " + this.A + " b = " + this.B + " c = " + this.C;
        }

        public static T operator *(Vector<T> first, Vector<T> second)
        {
            return (dynamic)first.A * second.A + (dynamic)first.B * second.B + (dynamic)first.C * second.C;
        }

        public double GetLength()
        {
            return Math.Sqrt((dynamic)this.A * this.A + (dynamic)this.B * this.B + (dynamic)this.C * this.C);
        }

        public double GetAngle(Vector<T> v2)
        {
            return (Math.Acos((double)((dynamic)this.A * v2.A + (dynamic)this.B * v2.B + (dynamic)this.C * v2.C) / (this.GetLength() * v2.GetLength()))) * (180 / Math.PI);
        }
    }
}
