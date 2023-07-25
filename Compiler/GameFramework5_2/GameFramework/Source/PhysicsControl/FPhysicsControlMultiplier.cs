#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsControlData.h")]
///<summary>These parameters allow modification of the parameters in FPhysicsControlData for two reasons:</summary>
public partial struct FPhysicsControlMultiplier {
// PhysicsControlMultiplier
	public FVector LinearStrengthMultiplier;
	public FVector LinearExtraDampingMultiplier;
	public FVector MaxForceMultiplier;
	public float AngularStrengthMultiplier;
	public float AngularExtraDampingMultiplier;
	public float MaxTorqueMultiplier;
}
