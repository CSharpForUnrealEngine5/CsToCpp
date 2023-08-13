namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceEffects/SourceEffectFilter.h")]
public partial struct FSourceEffectFilterSettings {
	public ESourceEffectFilterCircuit FilterCircuit;
	public ESourceEffectFilterType FilterType;
	public float CutoffFrequency;
	public float FilterQ;
	public TArray<FSourceEffectFilterAudioBusModulationSettings> AudioBusModulation;
}
