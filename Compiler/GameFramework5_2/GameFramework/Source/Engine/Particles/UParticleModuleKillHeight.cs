#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Kill/ParticleModuleKillHeight.h")]
public partial class UParticleModuleKillHeight : UParticleModuleKillBase {
	///<summary>The height at which to kill the particle.</summary>
	public FRawDistributionFloat Height;
	///<summary>If true, the height should be treated as a world-space position.</summary>
	public bool bAbsolute;
	///<summary>If true, the plane should be considered a floor - ie kill anything BELOW it.</summary>
	public bool bFloor;
	///<summary>If true, take the particle systems scale into account</summary>
	public bool bApplyPSysScale;
}
