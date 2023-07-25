using CSharpToCpp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    public struct FVector2D
    {
        public double X;
        public double Y;

        public FVector2D(double x, double y) { X = x; Y = y; }

        public static FVector2D ZeroVector;
        public static FVector2D UnitVector;
        public static FVector2D Unit45Vector;

    }
}
