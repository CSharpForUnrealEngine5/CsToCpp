#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomAssetPhysics.h")]
public partial struct FHairSimulationSetup {
	public bool bResetSimulation;
	public bool bDebugSimulation;
	public bool bLocalSimulation;
	public float LinearVelocityScale;
	public float AngularVelocityScale;
	public string LocalBone;
	public float TeleportDistance;
}
