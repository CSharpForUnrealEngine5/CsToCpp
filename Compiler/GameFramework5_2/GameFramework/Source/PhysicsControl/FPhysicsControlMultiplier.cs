namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>These parameters allow modification of the parameters in FPhysicsControlData for two reasons:</summary>
[CppInclude("PhysicsControlData.h")]
public partial struct FPhysicsControlMultiplier {
	public FVector LinearStrengthMultiplier;
	public FVector LinearExtraDampingMultiplier;
	public FVector MaxForceMultiplier;
	public float AngularStrengthMultiplier;
	public float AngularExtraDampingMultiplier;
	public float MaxTorqueMultiplier;
}
