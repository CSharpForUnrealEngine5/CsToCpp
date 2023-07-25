#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceEffects/SourceEffectFilter.h")]
public partial struct FSourceEffectFilterSettings {
// SourceEffectFilterSettings
	public ESourceEffectFilterCircuit FilterCircuit;
	public ESourceEffectFilterType FilterType;
	public float CutoffFrequency;
	public float FilterQ;
	public TArray<FSourceEffectFilterAudioBusModulationSettings> AudioBusModulation;
}
