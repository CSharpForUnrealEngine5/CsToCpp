namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceEffects/SourceEffectBitCrusher.h")]
public partial struct FSourceEffectBitCrusherSettings {
	public float CrushedSampleRate;
	public FSoundModulationDestinationSettings SampleRateModulation;
	public float CrushedBits;
	public FSoundModulationDestinationSettings BitModulation;
}
