#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Distortion data evaluated for given FZ pair based on lens parameters</summary>
[CppInclude("LensData.h")]
public partial struct FDistortionData {
	public TArray<FVector2D> DistortedUVs;
	public float OverscanFactor;
}
