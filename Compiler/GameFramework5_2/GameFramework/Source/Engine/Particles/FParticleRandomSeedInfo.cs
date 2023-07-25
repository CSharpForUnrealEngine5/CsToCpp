#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/ParticleModule.h")]
public partial struct FParticleRandomSeedInfo {
// ParticleRandomSeedInfo
	public string ParameterName;
	public bool bGetSeedFromInstance;
	public bool bInstanceSeedIsIndex;
	public bool bResetSeedOnEmitterLooping;
	public bool bRandomlySelectSeedArray;
	public TArray<int> RandomSeeds;
}
