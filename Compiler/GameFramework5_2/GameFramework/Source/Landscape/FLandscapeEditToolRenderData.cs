#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FLandscapeEditToolRenderData</summary>
[CppInclude("LandscapeComponent.h")]
public partial struct FLandscapeEditToolRenderData {
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
