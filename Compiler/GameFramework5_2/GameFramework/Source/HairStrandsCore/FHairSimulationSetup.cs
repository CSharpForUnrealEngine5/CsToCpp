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
