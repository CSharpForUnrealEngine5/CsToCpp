#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>BodySetup contains all collision information that is associated with a single asset.</summary>
[CppInclude("PhysicsEngine/BodySetup.h")]
public partial class UBodySetup : UBodySetupCore {
	///<summary>Simplified collision representation of this</summary>
	public FKAggregateGeom AggGeom;
	///<summary>If true (and bEnableFullAnimWeightBodies in SkelMeshComp is true), the physics of this bone will always be blended into the skeletal mesh, regardless of what PhysicsWeight of the SkelMeshComp is.</summary>
	public bool bAlwaysFullAnimWeight_DEPRECATED;
	///<summary>Should this BodySetup be considered for the bounding box of the PhysicsAsset (and hence SkeletalMeshComponent).</summary>
	public bool bConsiderForBounds;
	///<summary>If true, the physics of this mesh (only affects static meshes) will always contain ALL elements from the mesh - not just the ones enabled for collision.</summary>
	public bool bMeshCollideAll;
	///<summary>If true, the physics triangle mesh will use double sided faces when doing scene queries.</summary>
	public bool bDoubleSidedGeometry;
	///<summary>Should we generate data necessary to support collision on normal (non-mirrored) versions of this body.</summary>
	public bool bGenerateNonMirroredCollision;
	///<summary>Whether the cooked data is shared by multiple body setups. This is needed for per poly collision case where we don&#39;t want to duplicate cooked data, but still need multiple body setups for in place geometry changes</summary>
	public bool bSharedCookedData;
	///<summary>Should we generate data necessary to support collision on mirrored versions of this mesh.</summary>
	public bool bGenerateMirroredCollision;
	///<summary>If true, the physics triangle mesh will store UVs and the face remap table. This is needed</summary>
	public bool bSupportUVsAndFaceRemap;
	///<summary>TODO Chaos this is to opt out of CreatePhysicsMeshes for certain meshes</summary>
	public bool bNeverNeedsCookedCollisionData;
	///<summary>Physical material to use for simple collision on this body. Encodes information about density, friction etc.</summary>
	public UPhysicalMaterial PhysMaterial;
	///<summary>Custom walkable slope setting for this body.</summary>
	public FWalkableSlopeOverride WalkableSlopeOverride;
	///<summary>BuildScale_DEPRECATED</summary>
	public float BuildScale_DEPRECATED;
	///<summary>Default properties of the body instance, copied into objects on instantiation, was URB_BodyInstance</summary>
	public FBodyInstance DefaultInstance;
	///<summary>Build scale for this body setup (static mesh settings define this value)</summary>
	public FVector BuildScale3D;
}
