
using System;
public class Test
{
    static void Main()
    {
        int i = 0;
        ulong ul = 0;
        string s = "Test";

        Console.WriteLine("int: {0}", Utils.IsItFormattable(i));
        Console.WriteLine("ulong: {0}", Utils.IsItFormattable(ul));
        Console.WriteLine("String: {0}", Utils.IsItFormattable(s));

        Console.Read();
    }
}



