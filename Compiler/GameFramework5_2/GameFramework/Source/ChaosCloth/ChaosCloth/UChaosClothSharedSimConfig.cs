#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosCloth/ChaosClothConfig.h")]
///<summary>Chaos config settings shared between all instances of a skeletal mesh.</summary>
public partial class UChaosClothSharedSimConfig : UClothSharedConfigCommon {
// ChaosClothSharedSimConfig
	public int IterationCount;
	public int MaxIterationCount;
	public int SubdivisionCount;
	public float SelfCollisionThickness_DEPRECATED;
	public float CollisionThickness_DEPRECATED;
	public bool bUseDampingOverride_DEPRECATED;
	public float Damping_DEPRECATED;
	public bool bUseGravityOverride_DEPRECATED;
	public float GravityScale_DEPRECATED;
	public FVector Gravity_DEPRECATED;
	public bool bUseLocalSpaceSimulation;
	public bool bUseXPBDConstraints;
}
