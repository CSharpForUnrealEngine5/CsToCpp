namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the system which passes motion of the simulation&#39;s space into the simulation. This allows the simulation to pass a</summary>
[CppInclude("BoneControllers/AnimNode_RigidBody.h")]
public partial struct FSimSpaceSettings {
	public float WorldAlpha;
	public float VelocityScaleZ;
	public float MaxLinearVelocity;
	public float MaxAngularVelocity;
	public float MaxLinearAcceleration;
	public float MaxAngularAcceleration;
	public float ExternalLinearDrag_DEPRECATED;
	public FVector ExternalLinearDragV;
	public FVector ExternalLinearVelocity;
	public FVector ExternalAngularVelocity;
}
