// The Donut-Shaped in C#
using System;

class DonutAnimation
{
    static void Main(string[] args)
    {

        // Here I rewrote the code for the shaped donut from C in C#!
        double sin(double angle) => Math.Sin(angle);
        double cos(double angle) => Math.Cos(angle);

        float A = 0, B = 0;
        float[] z = new float[1760];
        char[] b = new char[1760];
        Console.Clear();
        for (; ; )
        {
            Array.Fill(b, ' ');
            Array.Fill(z, 0);
            for (double j = 0; 6.28 > j; j += 0.07)
            {
                for (double i = 0; 6.28 > i; i += 0.02)
                {
                    double sini = sin(i),
                           cosj = cos(j),
                           sinA = sin(A),
                           sinj = sin(j),
                           cosA = cos(A),
                           cosj2 = cosj + 2,
                           mess = 1 / (sini * cosj2 * sinA + sinj * cosA + 5),
                           cosi = cos(i),
                           cosB = cos(B),
                           sinB = sin(B),
                           t = sini * cosj2 * cosA - sinj * sinA;
                    int x = 40 + (int)(30 * mess * (cosi * cosj2 * cosB - t * sinB)),
                        y = 12 + (int)(15 * mess * (cosi * cosj2 * sinB + t * cosB)),
                        o = x + 80 * y,
                        N = (int)(8 * ((sinj * sinA - sini * cosj * cosA) * cosB - sini * cosj * sinA - sinj * cosA - cosi * cosj * sinB));
                    if (22 > y && y > 0 && x > 0 && 80 > x && mess > z[o])
                    {
                        z[o] = (float)mess;
                        b[o] = ".,-~:;=!*#$@"[N > 0 ? N : 0];
                    }
                }
            }
            Console.SetCursorPosition(0, 0);
            for (int k = 0; 1761 > k; k++)
            {
                Console.Write(k % 80 == 0 ? "\n" : b[k].ToString());
            }
            A += 0.04f;
            B += 0.02f;
        }
    }
}