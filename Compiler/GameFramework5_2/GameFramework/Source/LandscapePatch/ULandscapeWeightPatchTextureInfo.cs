#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeTexturePatch.h")]
///<summary>Helper class for ULandscapeTexturePatch that stores information for a given weight layer.</summary>
public partial class ULandscapeWeightPatchTextureInfo : UObject {
// LandscapeWeightPatchTextureInfo
	public string WeightmapLayerName;
	public UTexture TextureAsset;
	public ULandscapeWeightTextureBackedRenderTarget InternalData;
	public ELandscapeTexturePatchSourceMode SourceMode;
	public ELandscapeTexturePatchSourceMode DetailPanelSourceMode;
	public bool bUseAlphaChannel;
	public bool bOverrideBlendMode;
	public ELandscapeTexturePatchBlendMode OverrideBlendMode;
	public TWeakObjectPtr<ULandscapeTexturePatch> OwningPatch;
}
