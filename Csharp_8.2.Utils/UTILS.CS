namespace Utils
{
    using System;

    class Utils
    {

    //
    // Return the larger of two integer values
    //

    public static int Greater(int a, int b)
    {
        if (a>b)
            return a;
        else
            return b;

        // Alternative version - more terse
        // return (a>b) > (a) : (b);
    }

    //
    // Swap two integers, passed by reference
    //

    public static void Swap(ref int a, ref int b)
    {
        int temp;
        temp = a;
        a = b;
        b = temp;
    }

    //
    // Calculate factorial
    // and return the result as an out parameter
    //

    public static bool Factorial(int n, out int answer)
    {
        int k;        // loop counter
        int f;        // working value
        bool ok=true; // true if ok, false if not

        // Check the input value

        if (n<0)
            ok = false;

        // Calculate the factorial value as the
        // product of all the numbers from 2 to n

        try
        {
            checked
            {
                f = 1;
                for (k=2; k<=n; ++k)
                {
                    f = f * k;
                }       

                // Here is a terse alternative
                // for (f=1,k=2;k<=n;++k)
                //     f*=k;

            }
        }
        catch(Exception)
        {
            // If something goes wrong in the calculation,
            // catch it here. All exceptions
            // are handled the same way: set the result to
            // to zero and return false.

            f = 0;
            ok = false;
        }

        // assign result value                
        answer = f;

        // return to caller
        return ok;
    }

    //
    // Another way to solve the factorial problem, this time
    // as a recursive function
    //

    public static bool RecursiveFactorial(int n, out int f)
    {
        bool ok=true;

        // Trap negative inputs
        if (n<0)
        {
                f=0;
                ok = false;
        }

        if (n<=1)
            f=1;
        else
        {
            try
            {
                int pf;
                checked
                {       
                    ok = RecursiveFactorial(n-1,out pf);
                    f = n * pf;
                }
            }
            catch(Exception)
            {
                // Something went wrong. Set error
                // flag and return zero.
                f=0;
                ok=false;
            }
                               
        }

        return ok;
    }

    /*    public static void Reverse(ref string s)
        {
            string sRev = "";

            for (int k = s.Length – 1; k >= 0 ; k--)
            sRev = sRev + s[k];

            // Return result to caller
            s = sRev; 
        } */


        public static string Reverse(in string str, out string str1)
        {
            char[] dop;
            char simv;
            int i;
            dop = str.ToCharArray();
            for (i = 0; i < (dop.Length / 2); i++)
            {
                simv = dop[i];
                dop[i] = dop[dop.Length - i - 1];
                dop[dop.Length - i - 1] = simv;

            }
            str1 = new string(dop);
       //     Console.WriteLine(str1);

            return str1;
        }


    }
}
