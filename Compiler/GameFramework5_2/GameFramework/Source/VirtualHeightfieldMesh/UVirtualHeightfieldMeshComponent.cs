#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualHeightfieldMeshComponent.h")]
///<summary>Component to render a heightfield mesh using a virtual texture heightmap.</summary>
public partial class UVirtualHeightfieldMeshComponent : UPrimitiveComponent {
// VirtualHeightfieldMeshComponent
	public TSoftObjectPtr<ARuntimeVirtualTextureVolume> VirtualTexture;
	public ARuntimeVirtualTextureVolume VirtualTextureRef;
	public UObject VirtualTextureThumbnail;
	public bool bCopyBoundsButton;
	public UHeightfieldMinMaxTexture MinMaxTexture;
	public int NumMinMaxTextureBuildLevels;
	public bool bBuildMinMaxTextureButton;
	public UMaterialInterface Material;
	public float Lod0ScreenSize;
	public float Lod0Distribution;
	public float LodDistribution;
	public float LodBiasScale;
	public int NumForceLoadLods;
	public int NumOcclusionLods;
	public bool bHiddenInEditor;
	public bool bWorldPositionOffsetVelocity;
	public  void GatherHideFlags(bool InOutHidePrimitivesInEditor,bool InOutHidePrimitivesInGame) {}
}
