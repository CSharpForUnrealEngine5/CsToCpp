#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>Describes an entire curve that is used to compute a 3D vector output value from a float input.</summary>
public partial struct FInterpCurveVector {
// InterpCurveVector
	public TArray<FInterpCurvePointVector> Points;
	public bool bIsLooped;
	public float LoopKeyOffset;
}
