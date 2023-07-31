#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;

public partial struct FVector2D
{
    public FVector2D(double x, double y) { X = x; Y = y; }

    public static FVector2D ZeroVector;
    public static FVector2D UnitVector;
    public static FVector2D Unit45Vector;

}
