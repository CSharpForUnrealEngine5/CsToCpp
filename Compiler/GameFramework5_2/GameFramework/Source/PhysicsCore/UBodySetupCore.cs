namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BodySetupCore.h")]
public partial class UBodySetupCore : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Used in the PhysicsAsset case. Associates this Body with Bone in a skeletal mesh.</summary>
	public string BoneName;
	///<summary>If simulated it will use physics, if kinematic it will not be affected by physics, but can interact with physically simulated bodies. Default will inherit from OwnerComponent&#39;s behavior.</summary>
	public EPhysicsType PhysicsType;
	///<summary>Collision Trace behavior - by default, it will keep simple(convex)/complex(per-poly) separate *</summary>
	public ECollisionTraceFlag CollisionTraceFlag;
	///<summary>Collision Type for this body. This eventually changes response to collision to others *</summary>
	public EBodyCollisionResponse CollisionReponse;
}
