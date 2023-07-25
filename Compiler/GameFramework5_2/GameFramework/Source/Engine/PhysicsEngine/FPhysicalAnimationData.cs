#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicalAnimationComponent.h")]
///<summary>Stores info on the type of motor that will be used for a given bone</summary>
public partial struct FPhysicalAnimationData {
// PhysicalAnimationData
	public string BodyName;
	public bool bIsLocalSimulation;
	public float OrientationStrength;
	public float AngularVelocityStrength;
	public float PositionStrength;
	public float VelocityStrength;
	public float MaxLinearForce;
	public float MaxAngularForce;
}
