namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceEffects/SourceEffectBitCrusher.h")]
public partial class USourceEffectBitCrusherPreset : USoundEffectSourcePreset {
	public static UClass StaticClass() {return default;}
	///<summary>SetBits</summary>
	public void SetBits(float Bits) {}
	///<summary>SetBitModulator</summary>
	public void SetBitModulator(USoundModulatorBase Modulator) {}
	///<summary>SetBitModulators</summary>
	public void SetBitModulators(TSet<USoundModulatorBase> InModulators) {}
	///<summary>SetSampleRate</summary>
	public void SetSampleRate(float SampleRate) {}
	///<summary>SetSampleRateModulator</summary>
	public void SetSampleRateModulator(USoundModulatorBase Modulator) {}
	///<summary>SetSampleRateModulators</summary>
	public void SetSampleRateModulators(TSet<USoundModulatorBase> InModulators) {}
	///<summary>Sets just base (i.e. carrier) setting values without modifying modulation source references</summary>
	public void SetSettings(FSourceEffectBitCrusherBaseSettings Settings) {}
	///<summary>SetModulationSettings</summary>
	public void SetModulationSettings(FSourceEffectBitCrusherSettings ModulationSettings) {}
	///<summary>Settings</summary>
	public FSourceEffectBitCrusherSettings Settings;
}
