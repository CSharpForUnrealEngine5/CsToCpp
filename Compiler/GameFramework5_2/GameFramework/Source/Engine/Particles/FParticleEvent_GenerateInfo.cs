#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Event/ParticleModuleEventGenerator.h")]
public partial struct FParticleEvent_GenerateInfo {
// ParticleEvent_GenerateInfo
	public byte Type;
	public int Frequency;
	public int ParticleFrequency;
	public bool FirstTimeOnly;
	public bool LastTimeOnly;
	public bool UseReflectedImpactVector;
	public bool bUseOrbitOffset;
	public string CustomName;
	public TArray<UParticleModuleEventSendToGame> ParticleModuleEventsToSendToGame;
}
