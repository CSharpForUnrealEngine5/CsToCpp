namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Event/ParticleModuleEventGenerator.h")]
public partial struct FParticleEvent_GenerateInfo {
	public EParticleEventType Type;
	public int Frequency;
	public int ParticleFrequency;
	public bool FirstTimeOnly;
	public bool LastTimeOnly;
	public bool UseReflectedImpactVector;
	public bool bUseOrbitOffset;
	public string CustomName;
	public TArray<UParticleModuleEventSendToGame> ParticleModuleEventsToSendToGame;
}
