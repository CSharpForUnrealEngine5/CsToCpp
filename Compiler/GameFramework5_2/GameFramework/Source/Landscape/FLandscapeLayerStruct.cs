namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeProxy.h")]
public partial struct FLandscapeLayerStruct {
	public ULandscapeLayerInfoObject LayerInfoObj;
	public ULandscapeMaterialInstanceConstant ThumbnailMIC;
	public ALandscapeProxy Owner;
	public int DebugColorChannel;
	public bool bSelected;
	public string SourceFilePath;
}
