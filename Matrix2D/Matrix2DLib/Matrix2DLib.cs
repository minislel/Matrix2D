using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Matrix2DLib
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

        public Matrix2D(int a=1, int b = 0, int c = 0, int d = 1)
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
            return $"[[{A}, {B}], [{C}, {D}]]";
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
            return new Matrix2D(m1.A * m2.A + m1.B*m2.C, m1.A * m2.B+ m1.B*m2.D, m1.C * m2.A + m1.D*m2.C, m1.C * m2.B+m1.D*m2.D);
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
        public Matrix2D Transpose()
        {
            return new Matrix2D(this.A, this.C, this.B, this.D);
        }
        public static int Determinant(Matrix2D m)
        { return m.A * m.D - m.B * m.C; }
        public int Det()
        { return this.A * this.D - this.B * this.C; }
        public static explicit operator int[,](Matrix2D m)
        {
            return new int[,] { { m.A, m.B }, { m.C, m.D } };
        }
        public static Matrix2D Parse(string? input)
        {
            
            if (input == null) { throw new FormatException(); }
                try
            {
                int[][] jaggedArray = JsonConvert.DeserializeObject<int[][]>(input);
                int[,] result = new int[jaggedArray.Length, jaggedArray[0].Length];
                for (int i = 0; i < jaggedArray.Length; i++)
                {
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        result[i, j] = jaggedArray[i][j];
                    }
                }
                return new Matrix2D(result[0,0], result[0,1], result[1,0], result[1,1]);
            }
            catch
            {
                throw new FormatException();
            }
            
        }


    }
}
