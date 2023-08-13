namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeMaterialInstanceConstant.h")]
public partial class ULandscapeMaterialInstanceConstant : UMaterialInstanceConstant {
	public static UClass StaticClass() {return default;}
	///<summary>TextureStreamingInfo</summary>
	public TArray<FLandscapeMaterialTextureStreamingInfo> TextureStreamingInfo;
	///<summary>bIsLayerThumbnail</summary>
	public bool bIsLayerThumbnail;
	///<summary>bDisableTessellation_DEPRECATED</summary>
	public bool bDisableTessellation_DEPRECATED;
	///<summary>bMobile</summary>
	public bool bMobile;
	///<summary>bEditorToolUsage</summary>
	public bool bEditorToolUsage;
}
