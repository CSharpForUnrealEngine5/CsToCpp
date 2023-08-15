namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper class for ULandscapeTexturePatch that stores information for a given weight layer.</summary>
[CppInclude("LandscapeTexturePatch.h")]
public partial class ULandscapeWeightPatchTextureInfo : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>WeightmapLayerName</summary>
	public FName WeightmapLayerName;
	///<summary>Texture to use when source mode is set to texture asset.</summary>
	public UTexture TextureAsset;
	///<summary>Not directly settable via detail panel- for display/debugging purposes only.</summary>
	public ULandscapeWeightTextureBackedRenderTarget InternalData;
	///<summary>SourceMode</summary>
	public ELandscapeTexturePatchSourceMode SourceMode;
	///<summary>DetailPanelSourceMode</summary>
	public ELandscapeTexturePatchSourceMode DetailPanelSourceMode;
	///<summary>bUseAlphaChannel</summary>
	public bool bUseAlphaChannel;
	///<summary>Can&#39;t make TOptional a UPROPERTY, hence these two.</summary>
	public bool bOverrideBlendMode;
	///<summary>OverrideBlendMode</summary>
	public ELandscapeTexturePatchBlendMode OverrideBlendMode;
	///<summary>Needed mainly so that we can get at the resolution...</summary>
	public TWeakObjectPtr<ULandscapeTexturePatch> OwningPatch;
}
