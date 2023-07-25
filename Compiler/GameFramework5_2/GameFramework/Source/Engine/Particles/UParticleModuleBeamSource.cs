#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Beam/ParticleModuleBeamSource.h")]
public partial class UParticleModuleBeamSource : UParticleModuleBeamBase {
// ParticleModuleBeamSource
	public byte SourceMethod;
	public string SourceName;
	public bool bSourceAbsolute;
	public FRawDistributionVector Source;
	public bool bLockSource;
	public byte SourceTangentMethod;
	public FRawDistributionVector SourceTangent;
	public bool bLockSourceTangent;
	public FRawDistributionFloat SourceStrength;
	public bool bLockSourceStength;
}
