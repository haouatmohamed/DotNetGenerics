using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetGenerics
{
    // Exercise: improve this code 
    internal static class EqualityVerifier
    {
        public static bool AreEqual(int a, int b)
        {
            return a == b;
        }

        public static bool AreEqual(string a, string b)
        {
            return a == b;
        }

        public static bool AreEqual(double a, double b)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return a == b;
        }
    }
}
