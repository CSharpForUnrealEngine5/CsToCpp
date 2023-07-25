#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_RigidBody.h")]
///<summary>Settings for the system which passes motion of the simulation's space into the simulation. This allows the simulation to pass a</summary>
public partial struct FSimSpaceSettings {
// SimSpaceSettings
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
