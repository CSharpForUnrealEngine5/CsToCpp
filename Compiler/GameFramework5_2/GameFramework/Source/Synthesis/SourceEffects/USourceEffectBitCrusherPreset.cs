#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceEffects/SourceEffectBitCrusher.h")]
public partial class USourceEffectBitCrusherPreset : USoundEffectSourcePreset {
// SourceEffectBitCrusherPreset
	public  void SetBits(float Bits) {}
	public  void SetBitModulator(USoundModulatorBase Modulator) {}
	public  void SetBitModulators(TSet<USoundModulatorBase> InModulators) {}
	public  void SetSampleRate(float SampleRate) {}
	public  void SetSampleRateModulator(USoundModulatorBase Modulator) {}
	public  void SetSampleRateModulators(TSet<USoundModulatorBase> InModulators) {}
	public  void SetSettings(FSourceEffectBitCrusherBaseSettings Settings) {}
	public  void SetModulationSettings(FSourceEffectBitCrusherSettings ModulationSettings) {}
	public FSourceEffectBitCrusherSettings Settings;
}
