#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeComponent.h")]
///<summary>FLandscapeEditToolRenderData</summary>
public partial struct FLandscapeEditToolRenderData {
// LandscapeEditToolRenderData
	public UMaterialInterface ToolMaterial;
	public UMaterialInterface GizmoMaterial;
	public int SelectedType;
	public int DebugChannelR;
	public int DebugChannelG;
	public int DebugChannelB;
	public UTexture2D DataTexture;
	public UTexture2D LayerContributionTexture;
	public UTexture2D DirtyTexture;
}
