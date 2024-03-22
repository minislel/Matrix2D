using Matrix2DLib;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Matrix2D A = new Matrix2D(1, 2, 3, 4);
            Matrix2D B = new Matrix2D(5, 6, 7, 8);

            
            Console.WriteLine("Macierz A:");
            Console.WriteLine(A);

            Console.WriteLine("\nMacierz B:");
            Console.WriteLine(B);

            
            Matrix2D C = A + B;
            Console.WriteLine("\nSuma macierzy A + B:");
            Console.WriteLine(C);

            
            Matrix2D D = A - B;
            Console.WriteLine("\nRóżnica macierzy A - B:");
            Console.WriteLine(D);

            
            Matrix2D E = A * B;
            Console.WriteLine("\nIloczyn macierzy A * B:");
            Console.WriteLine(E);
            Matrix2D E1 = B * A;
            Console.WriteLine("\nIloczyn macierzy B * A:");
            Console.WriteLine(E1);


            int k = 2;
            Matrix2D F = A * k;
            Console.WriteLine($"\nMacierz A pomnożona przez {k}:");
            Console.WriteLine(F);

            Matrix2D G = k * B;
            Console.WriteLine($"\nMacierz B pomnożona przez {k}:");
            Console.WriteLine(G);

            Console.WriteLine("\nTranspozycja macierzy A:");
            Console.WriteLine(A.Transpose());

            
            Console.WriteLine($"\nWyznacznik macierzy A: {Matrix2D.Determinant(A)}");
            Console.WriteLine($"Wyznacznik macierzy B: {B.Det()}");

            
            int[,] array = (int[,])A;
            Console.WriteLine("\nRzutowanie macierzy A na tablicę 2x2:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            string matrixString = "[[2, 1], [3, 2]]";
            Matrix2D parsedMatrix = Matrix2D.Parse(matrixString);
            Console.WriteLine($"Macierz zparsowana ze stringa {matrixString}:");
            Console.WriteLine(parsedMatrix);

            Console.WriteLine("\nCzy macierz A jest taka sama jak B?");
            string result = A == B ? "Wychodzi na to, ze tak": "Wychodzi na to, ze nie";
            Console.WriteLine(result);
            Console.WriteLine("\nMacierz -A: ");
            Console.WriteLine(-A);
        }
    }
}
