#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Beam/ParticleModuleBeamTarget.h")]
public partial class UParticleModuleBeamTarget : UParticleModuleBeamBase {
// ParticleModuleBeamTarget
	public Beam2SourceTargetMethod TargetMethod;
	public string TargetName;
	public FRawDistributionVector Target;
	public bool bTargetAbsolute;
	public bool bLockTarget;
	public Beam2SourceTargetTangentMethod TargetTangentMethod;
	public FRawDistributionVector TargetTangent;
	public bool bLockTargetTangent;
	public FRawDistributionFloat TargetStrength;
	public bool bLockTargetStength;
	public float LockRadius;
}
