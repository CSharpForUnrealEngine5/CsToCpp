namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeInfo.h")]
public partial struct FLandscapeInfoLayerSettings {
	public ULandscapeLayerInfoObject LayerInfoObj;
	public FName LayerName;
	public UMaterialInstanceConstant ThumbnailMIC;
	public ALandscapeProxy Owner;
	public int DebugColorChannel;
	public bool bValid;
}
