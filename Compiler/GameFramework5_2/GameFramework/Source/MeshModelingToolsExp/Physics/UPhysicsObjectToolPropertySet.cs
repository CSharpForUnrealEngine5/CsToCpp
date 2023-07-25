#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Physics/CollisionPropertySets.h")]
public partial class UPhysicsObjectToolPropertySet : UInteractiveToolPropertySet {
// PhysicsObjectToolPropertySet
	public string ObjectName;
	public ECollisionGeometryMode CollisionType;
	public TArray<FPhysicsSphereData> Spheres;
	public TArray<FPhysicsBoxData> Boxes;
	public TArray<FPhysicsCapsuleData> Capsules;
	public TArray<FPhysicsConvexData> Convexes;
	public TArray<FPhysicsLevelSetData> LevelSets;
}
