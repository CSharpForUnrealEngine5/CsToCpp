using CSharpToCpp.Utilities;

namespace GameFramework
{
    [CppIgnoreNew]
    public struct FColor
    {
        public byte B, G, R, A;

        public FColor(byte r, byte g, byte b, byte a)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }

        public static FColor FromHex(string hexString) { return new FColor(); }

        public static FColor White;
        public static FColor Black;
        public static FColor Transparent;
        public static FColor Red;
        public static FColor Green;
        public static FColor Blue;
        public static FColor Yellow;
        public static FColor Cyan;
        public static FColor Magenta;
        public static FColor Orange;
        public static FColor Purple;
        public static FColor Turquoise;
        public static FColor Silver;
        public static FColor Emerald;
    }
}
