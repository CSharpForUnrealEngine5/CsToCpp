namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Physics/CollisionPropertySets.h")]
public partial class UPhysicsObjectToolPropertySet : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Source Object Name</summary>
	public string ObjectName;
	///<summary>Collision Flags controlling how simple and complex collision shapes are used</summary>
	public ECollisionGeometryMode CollisionType;
	///<summary>Spheres</summary>
	public TArray<FPhysicsSphereData> Spheres;
	///<summary>Boxes</summary>
	public TArray<FPhysicsBoxData> Boxes;
	///<summary>Capsules</summary>
	public TArray<FPhysicsCapsuleData> Capsules;
	///<summary>Convexes</summary>
	public TArray<FPhysicsConvexData> Convexes;
	///<summary>LevelSets</summary>
	public TArray<FPhysicsLevelSetData> LevelSets;
}
