#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceEffects/SourceEffectRingModulation.h")]
public partial struct FSourceEffectRingModulationSettings {
// SourceEffectRingModulationSettings
	public ERingModulatorTypeSourceEffect ModulatorType;
	public float Frequency;
	public float Depth;
	public float DryLevel;
	public float WetLevel;
	public UAudioBus AudioBusModulator;
}
