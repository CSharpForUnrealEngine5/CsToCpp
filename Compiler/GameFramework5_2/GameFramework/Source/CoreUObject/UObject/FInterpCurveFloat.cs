#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>Describes an entire curve that is used to compute a float output value from a float input.</summary>
public partial struct FInterpCurveFloat {
// InterpCurveFloat
	public TArray<FInterpCurvePointFloat> Points;
	public bool bIsLooped;
	public float LoopKeyOffset;
}
