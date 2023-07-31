#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct for dynamic (per-frame) lens data</summary>
[CppInclude("LiveLinkLensTypes.h")]
public partial struct FLiveLinkLensFrameData {
	public TArray<float> DistortionParameters;
	public FVector2D FxFy;
	public FVector2D PrincipalPoint;
}
