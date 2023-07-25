#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/BodySetup.h")]
///<summary>BodySetup contains all collision information that is associated with a single asset.</summary>
public partial class UBodySetup : UBodySetupCore {
// BodySetup
	public FKAggregateGeom AggGeom;
	public bool bAlwaysFullAnimWeight_DEPRECATED;
	public bool bConsiderForBounds;
	public bool bMeshCollideAll;
	public bool bDoubleSidedGeometry;
	public bool bGenerateNonMirroredCollision;
	public bool bSharedCookedData;
	public bool bGenerateMirroredCollision;
	public bool bSupportUVsAndFaceRemap;
	public bool bNeverNeedsCookedCollisionData;
	public UPhysicalMaterial PhysMaterial;
	public FWalkableSlopeOverride WalkableSlopeOverride;
	public float BuildScale_DEPRECATED;
	public FBodyInstance DefaultInstance;
	public FVector BuildScale3D;
}
