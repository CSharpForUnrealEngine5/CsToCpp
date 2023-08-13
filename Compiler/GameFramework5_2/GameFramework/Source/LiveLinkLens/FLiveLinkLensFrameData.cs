namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct for dynamic (per-frame) lens data</summary>
[CppInclude("LiveLinkLensTypes.h")]
public partial struct FLiveLinkLensFrameData {
	public TArray<float> DistortionParameters;
	public FVector2D FxFy;
	public FVector2D PrincipalPoint;
}
