#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes an entire curve that is used to compute a color output value from a float input.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FInterpCurveLinearColor {
	public TArray<FInterpCurvePointLinearColor> Points;
	public bool bIsLooped;
	public float LoopKeyOffset;
}
