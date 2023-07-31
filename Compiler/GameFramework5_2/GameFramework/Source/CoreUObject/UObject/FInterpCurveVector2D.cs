#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes an entire curve that is used to compute a 2D vector output value from a float input.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FInterpCurveVector2D {
	public TArray<FInterpCurvePointVector2D> Points;
	public bool bIsLooped;
	public float LoopKeyOffset;
}
