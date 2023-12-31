namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes an entire curve that is used to compute a 3D vector output value from a float input.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FInterpCurveVector {
	public TArray<FInterpCurvePointVector> Points;
	public bool bIsLooped;
	public float LoopKeyOffset;
}
