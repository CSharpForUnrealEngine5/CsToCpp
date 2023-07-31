#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeHeightfieldCollisionComponent.h")]
public partial class ULandscapeHeightfieldCollisionComponent : UPrimitiveComponent {
	///<summary>List of layers painted on this component. Matches the WeightmapLayerAllocations array in the LandscapeComponent.</summary>
	public TArray<ULandscapeLayerInfoObject> ComponentLayerInfos;
	///<summary>Offset of component in landscape quads</summary>
	public int SectionBaseX;
	///<summary>SectionBaseY</summary>
	public int SectionBaseY;
	///<summary>Size of component in collision quads</summary>
	public int CollisionSizeQuads;
	///<summary>Collision scale: (ComponentSizeQuads) / (CollisionSizeQuads)</summary>
	public float CollisionScale;
	///<summary>Size of component&#39;s &quot;simple collision&quot; in collision quads</summary>
	public int SimpleCollisionSizeQuads;
	///<summary>The flags for each collision quad. See ECollisionQuadFlags.</summary>
	public TArray<byte> CollisionQuadFlags;
	///<summary>Guid used to share Physics heightfield objects in the editor</summary>
	public FGuid HeightfieldGuid;
	///<summary>Cached local-space bounding box, created at heightmap update time</summary>
	public FBox CachedLocalBox;
	///<summary>Reference to render component</summary>
	public TLazyObjectPtr<ULandscapeComponent> RenderComponent_DEPRECATED;
	///<summary>Reference to render component</summary>
	public ULandscapeComponent RenderComponentRef;
	///<summary>Returns associated landscape component</summary>
	public  ULandscapeComponent GetRenderComponent() { return default; }
	///<summary>CollisionHash</summary>
	public uint CollisionHash;
	///<summary>Physical materials objects referenced by the indices in PhysicalMaterialRenderData. Stripped from cooked content</summary>
	public TArray<UPhysicalMaterial> PhysicalMaterialRenderObjects;
	///<summary>This is a list of physical materials that is actually used by a cooked HeightField</summary>
	public TArray<UPhysicalMaterial> CookedPhysicalMaterials;
}
