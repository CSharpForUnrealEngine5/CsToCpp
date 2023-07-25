#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkLensTypes.h")]
///<summary>Struct for dynamic (per-frame) lens data</summary>
public partial struct FLiveLinkLensFrameData {
// LiveLinkLensFrameData
	public TArray<float> DistortionParameters;
	public FVector2D FxFy;
	public FVector2D PrincipalPoint;
}
