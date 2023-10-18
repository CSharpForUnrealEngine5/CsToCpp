#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;

public partial struct FTransform
{
    static FTransform Identity;

    public FTransform(FVector InTranslation)
    {
        Rotation = new FQuat();
        Translation = new FVector();
        Scale3D = new FVector();
    }
    public FTransform(FQuat InTranslation)
    {
        Rotation = new FQuat();
        Translation = new FVector();
        Scale3D = new FVector();
    }
    public FTransform(FRotator InTranslation)
    {
        Rotation = new FQuat();
        Translation = new FVector();
        Scale3D = new FVector();
    }
    public FTransform(FRotator InRotator, FVector InTranslation, FVector inScale)
    {
        Rotation = new FQuat();
        Translation = new FVector();
        Scale3D = new FVector();
    }
    public FTransform(FRotator InRotator, FVector InTranslation)
    {
        Rotation = new FQuat();
        Translation = new FVector();
        Scale3D = new FVector();
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
