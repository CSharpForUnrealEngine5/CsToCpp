namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicsConstraintActor.h")]
public partial class APhysicsConstraintActor : ARigidBodyBase {
	public static UClass StaticClass() {return default;}
	///<summary>ConstraintComp</summary>
	public UPhysicsConstraintComponent ConstraintComp;
	///<summary>ConstraintActor1_DEPRECATED</summary>
	public AActor ConstraintActor1_DEPRECATED;
	///<summary>ConstraintActor2_DEPRECATED</summary>
	public AActor ConstraintActor2_DEPRECATED;
	///<summary>bDisableCollision_DEPRECATED</summary>
	public bool bDisableCollision_DEPRECATED;
}
