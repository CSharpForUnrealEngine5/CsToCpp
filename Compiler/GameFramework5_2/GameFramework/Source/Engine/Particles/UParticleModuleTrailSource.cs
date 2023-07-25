#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Trail/ParticleModuleTrailSource.h")]
public partial class UParticleModuleTrailSource : UParticleModuleTrailBase {
// ParticleModuleTrailSource
	public byte SourceMethod;
	public string SourceName;
	public FRawDistributionFloat SourceStrength;
	public bool bLockSourceStength;
	public int SourceOffsetCount;
	public TArray<FVector> SourceOffsetDefaults;
	public byte SelectionMethod;
	public bool bInheritRotation;
}
