#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>Describes an entire curve that is used to compute two 3D vector values from a float input.</summary>
public partial struct FInterpCurveTwoVectors {
// InterpCurveTwoVectors
	public TArray<FInterpCurvePointTwoVectors> Points;
	public bool bIsLooped;
	public float LoopKeyOffset;
}
