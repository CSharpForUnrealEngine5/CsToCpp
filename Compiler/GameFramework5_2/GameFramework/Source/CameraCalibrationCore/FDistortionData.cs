#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensData.h")]
///<summary>Distortion data evaluated for given FZ pair based on lens parameters</summary>
public partial struct FDistortionData {
// DistortionData
	public TArray<FVector2D> DistortedUVs;
	public float OverscanFactor;
}
