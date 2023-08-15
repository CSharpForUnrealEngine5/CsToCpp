namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stores info on the type of motor that will be used for a given bone</summary>
[CppInclude("PhysicsEngine/PhysicalAnimationComponent.h")]
public partial struct FPhysicalAnimationData {
	public FName BodyName;
	public bool bIsLocalSimulation;
	public float OrientationStrength;
	public float AngularVelocityStrength;
	public float PositionStrength;
	public float VelocityStrength;
	public float MaxLinearForce;
	public float MaxAngularForce;
}
