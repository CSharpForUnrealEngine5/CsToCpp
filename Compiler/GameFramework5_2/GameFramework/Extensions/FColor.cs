using CSharpToCpp.Utilities;

namespace GameFramework;

[CppIgnoreNew]
public partial struct FColor
{
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

public partial struct FLinearColor
{
    public FLinearColor(float r, float g, float b) { R = r; B = b; G = g; A = 1.0f; }
    public static FLinearColor White;
    public static FLinearColor Gray;
    public static FLinearColor Black;
    public static FLinearColor Transparent;
    public static FLinearColor Red;
    public static FLinearColor Green;
    public static FLinearColor Blue;
    public static FLinearColor Yellow;

}