namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Event/ParticleModuleEventReceiverBase.h")]
public partial class UParticleModuleEventReceiverBase : UParticleModuleEventBase {
	public static UClass StaticClass() {return default;}
	///<summary>The type of event that will generate the kill.</summary>
	public EParticleEventType EventGeneratorType;
	///<summary>The name of the emitter of interest for generating the event.</summary>
	public string EventName;
}
