namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes an entire curve that is used to compute a quaternion output value from a float input.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FInterpCurveQuat {
	public TArray<FInterpCurvePointQuat> Points;
	public bool bIsLooped;
	public float LoopKeyOffset;
}
