using System;
using System.Globalization;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
          
            float f1 = float.Parse(args[0]);
            float f2 = float.Parse(args[1]);
            float f3 = float.Parse(args[2]);
            float f4 = float.Parse(args[3]);
            float f5 = float.Parse(args[4]);
            float f6 = float.Parse(args[5]);

            float[,] a1 = { { f1, f2}, { f3, f4} };
            float[] a2 = { f5, f6};
            float[] resultado = new float[2];

                for (int i = 0; i < 2; i++)
            {
                resultado[i] = 0;
                    for (int j = 0;j<2;j++)
                {
                    resultado[i] += a1[i, j] * a2[j];
                }
            }
                for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"| {resultado[i],6:F2} |");
            }
        }
    }
}