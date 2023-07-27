#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Beam/ParticleModuleBeamSource.h")]
public partial class UParticleModuleBeamSource : UParticleModuleBeamBase {
// ParticleModuleBeamSource
	public Beam2SourceTargetMethod SourceMethod;
	public string SourceName;
	public bool bSourceAbsolute;
	public FRawDistributionVector Source;
	public bool bLockSource;
	public Beam2SourceTargetTangentMethod SourceTangentMethod;
	public FRawDistributionVector SourceTangent;
	public bool bLockSourceTangent;
	public FRawDistributionFloat SourceStrength;
	public bool bLockSourceStength;
}
