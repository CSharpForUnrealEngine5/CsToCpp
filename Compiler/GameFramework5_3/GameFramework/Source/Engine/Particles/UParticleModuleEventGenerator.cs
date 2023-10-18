namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Event/ParticleModuleEventGenerator.h")]
public partial class UParticleModuleEventGenerator : UParticleModuleEventBase {
	public static UClass StaticClass() {return default;}
	///<summary>Events</summary>
	public TArray<FParticleEvent_GenerateInfo> Events;
}
