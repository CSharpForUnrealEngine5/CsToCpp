#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeHeightfieldCollisionComponent.h")]
public partial class ULandscapeHeightfieldCollisionComponent : UPrimitiveComponent {
// LandscapeHeightfieldCollisionComponent
	public TArray<ULandscapeLayerInfoObject> ComponentLayerInfos;
	public int SectionBaseX;
	public int SectionBaseY;
	public int CollisionSizeQuads;
	public float CollisionScale;
	public int SimpleCollisionSizeQuads;
	public TArray<byte> CollisionQuadFlags;
	public FGuid HeightfieldGuid;
	public FBox CachedLocalBox;
	public TLazyObjectPtr<ULandscapeComponent> RenderComponent_DEPRECATED;
	public ULandscapeComponent RenderComponentRef;
	public  ULandscapeComponent GetRenderComponent() { return default; }
	public uint CollisionHash;
	public TArray<UPhysicalMaterial> PhysicalMaterialRenderObjects;
	public TArray<UPhysicalMaterial> CookedPhysicalMaterials;
}
