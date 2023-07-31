#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component to render a heightfield mesh using a virtual texture heightmap.</summary>
[CppInclude("VirtualHeightfieldMeshComponent.h")]
public partial class UVirtualHeightfieldMeshComponent : UPrimitiveComponent {
	///<summary>The RuntimeVirtualTextureVolume that contains virtual texture heightmap.</summary>
	public TSoftObjectPtr<ARuntimeVirtualTextureVolume> VirtualTexture;
	///<summary>UObject ref resolved from VirtualTexture weak ref.</summary>
	public ARuntimeVirtualTextureVolume VirtualTextureRef;
	///<summary>Placeholder for details customization image.</summary>
	public UObject VirtualTextureThumbnail;
	///<summary>Placeholder for details customization button.</summary>
	public bool bCopyBoundsButton;
	///<summary>Texture object containing minimum and maximum height values.</summary>
	public UHeightfieldMinMaxTexture MinMaxTexture;
	///<summary>Number of levels to build in the MinMax Texture. A default value of 0 will build all levels from the heightfield.</summary>
	public int NumMinMaxTextureBuildLevels;
	///<summary>Placeholder for details customization button.</summary>
	public bool bBuildMinMaxTextureButton;
	///<summary>The material to apply.</summary>
	public UMaterialInterface Material;
	///<summary>Target screen size for a LOD 0 tile. A smaller value uniformly increases the geometry resolution on screen.</summary>
	public float Lod0ScreenSize;
	///<summary>Distribution multiplier applied only for LOD 0. A larger value increases the distance to the first LOD transition.</summary>
	public float Lod0Distribution;
	///<summary>Distribution multiplier applied for each LOD level. A larger value increases the distance exponentially between each LOD transition.</summary>
	public float LodDistribution;
	///<summary>Scale applied to LodBias texture. A larger value increases resolution where the LodBias texture is set.</summary>
	public float LodBiasScale;
	///<summary>The number of levels that we force loaded. A higher number can reduce LOD pop in but allocates more of the virtual texture memory pool.</summary>
	public int NumForceLoadLods;
	///<summary>The number of levels that we calculate occlusion volumes for. A higher number gives finer occlusion at the cost of more queries.</summary>
	public int NumOcclusionLods;
	///<summary>Allows us to only see this actor in game and not in the Editor. This is useful if we only want to see the Heightfield virtual texture source primitives during edition.</summary>
	public bool bHiddenInEditor;
	///<summary>Allows material World Position Offset to contribute to velocity rendering.</summary>
	public bool bWorldPositionOffsetVelocity;
	///<summary>Function used by the VirtualTexture delegate to retrieve our HidePrimitives flags.</summary>
	public  void GatherHideFlags(bool InOutHidePrimitivesInEditor,bool InOutHidePrimitivesInGame) {}
}
