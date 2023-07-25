#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComposureUVMap.h")]
public partial struct FComposureUVMapSettings {
// ComposureUVMapSettings
	public FMatrix PreUVDisplacementMatrix;
	public FMatrix PostUVDisplacementMatrix;
	public FVector2D DisplacementDecodeParameters;
	public UTexture DisplacementTexture;
	public bool bUseDisplacementBlueAndAlphaChannels;
}
