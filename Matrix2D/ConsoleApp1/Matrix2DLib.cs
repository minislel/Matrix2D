using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix2DConsoleApp
{
    public class Matrix2D : IEquatable<Matrix2D>
    {
        public int A { get; private set; }
        public int B { get; private set; }
        public int C { get; private set; }
        public int D { get; private set; }
        public static Matrix2D Id
        {
            get
            {
                return new Matrix2D();
            }
        }
        public static Matrix2D Zero
        {
            get
            {
                return new Matrix2D(0, 0, 0, 0);
            }
        }

        public Matrix2D(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        public Matrix2D()
        {
            A = 1;
            B = 0;
            C = 0;
            D = 1;
        }
        public override string ToString()
        {
            return $"[[{A}, {B}][{C}, {D}]]";
        }

        public bool Equals(Matrix2D? other)
        {
            if (other == null) return false;
            if (this.A == other.A && this.B == other.B && this.C == other.C && this.D == other.D)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Matrix2D);
        }
        public override int GetHashCode()
        {
            return A.GetHashCode() ^ B.GetHashCode() ^ C.GetHashCode() ^ D.GetHashCode();
        }
        public static Matrix2D operator +(Matrix2D m1, Matrix2D m2)
        {
            return new Matrix2D(m1.A+m2.A, m1.B+m2.B, m1.C+m2.C, m1.D+m2.D);
        }
        public static Matrix2D operator -(Matrix2D m1, Matrix2D m2)
        {
            return new Matrix2D(m1.A - m2.A, m1.B - m2.B, m1.C - m2.C, m1.D - m2.D);
        }
        public static Matrix2D operator *(Matrix2D m1, Matrix2D m2)
        {
            return new Matrix2D(m1.A * m2.A, m1.B * m2.B, m1.C * m2.C, m1.D * m2.D);
        }
        public static Matrix2D operator *(Matrix2D m, int k)
        {
            return new Matrix2D(m.A * k, m.B*k, m.C*k, m.D*k);
        }
        public static Matrix2D operator *(int k, Matrix2D m)
        {
            return new Matrix2D(m.A * k, m.B * k, m.C * k, m.D * k);
        }
        public static Matrix2D operator -(Matrix2D m)
        {
            return new Matrix2D(m.A * -1, m.B * -1, m.C * -1, m.D * -1);
        }


    }
}
