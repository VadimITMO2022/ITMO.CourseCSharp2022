
using System;
using System.Security.Cryptography;

class MatrixMultiply {
    static void Main()
    {
        int[,] a = new int[2, 2];
        /* a[0, 0] = 1; a[0, 1] = 2;
         a[1, 0] = 3; a[1, 1] = 4; */

       /* string s = Console.ReadLine();
        a[0, 0] = int.Parse(s);
               s = Console.ReadLine();
        a[0, 1] = int.Parse(s);
               s = Console.ReadLine();
        a[1, 0] = int.Parse(s);
               s = Console.ReadLine();
        a[1, 1] = int.Parse(s); */

        Input(a);



        int[,] b = new int[2, 2];

        /*  b[0, 0] = 5; b[0, 1] = 6;
          b[1, 0] = 7; b[1, 1] = 8; */

        Input(b);

        int[,] result = new int[2, 2];
        /* result[0, 0] = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0];
         result[0, 1] = a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1];
         result[1, 0] = a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0];
         result[1, 1] = a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1]; */


        result = Multiply(a, b);
       

        Output(result);

        Console.Read();
    }

    static void Input(int[,] dst)
    {
        for (int r = 0; r < 2; r++)
        {
            for (int c = 0; c < 2; c++)
            {
                Console.Write("Enter value for [{0},{1}] : ", r, c);
                string s = Console.ReadLine();
                dst[r, c] = int.Parse(s);
            }
        }
        Console.WriteLine();
    }


    static int[,] Multiply(int[,] a, int[,] b)
    {
        int[,] result = new int[2, 2];
        for (int r = 0; r < 2; r++)
        {
            for (int c = 0; c < 2; c++)
            {
                result[r, c] += a[r, 0] * b[0, c] + a[r, 1] * b[1, c];
            }
        }
        return result;
    }




    static void Output(int[,] result)
    {
        for (int r = 0; r < result.GetLength(0); r++)
        {
            for (int c = 0; c < result.GetLength(1); c++)
            {

                Console.Write("{0} ", result[r, c]);
            }
            Console.WriteLine();
        }

    }


}

