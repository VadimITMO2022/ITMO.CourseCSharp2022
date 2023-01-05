
    using System;

    class Utils
    {
        public static bool IsItFormattable(object x)
        {
            // Use the is operator to test whether the
            // object has the IFormattable interface

            if (x is IFormattable)
                return true;
            else
                return false;
        }
    }
