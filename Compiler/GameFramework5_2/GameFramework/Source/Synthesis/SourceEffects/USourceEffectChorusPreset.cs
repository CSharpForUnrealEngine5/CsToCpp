#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceEffects/SourceEffectChorus.h")]
public partial class USourceEffectChorusPreset : USoundEffectSourcePreset {
	public static UClass StaticClass() {return default;}
	///<summary>SetDepth</summary>
	public  void SetDepth(float Depth) {}
	///<summary>SetDepthModulator</summary>
	public  void SetDepthModulator(USoundModulatorBase Modulator) {}
	///<summary>SetDepthModulators</summary>
	public  void SetDepthModulators(TSet<USoundModulatorBase> Modulators) {}
	///<summary>SetFeedback</summary>
	public  void SetFeedback(float Feedback) {}
	///<summary>SetFeedbackModulator</summary>
	public  void SetFeedbackModulator(USoundModulatorBase Modulator) {}
	///<summary>SetFeedbackModulators</summary>
	public  void SetFeedbackModulators(TSet<USoundModulatorBase> Modulators) {}
	///<summary>SetFrequency</summary>
	public  void SetFrequency(float Frequency) {}
	///<summary>SetFrequencyModulator</summary>
	public  void SetFrequencyModulator(USoundModulatorBase Modulator) {}
	///<summary>SetFrequencyModulators</summary>
	public  void SetFrequencyModulators(TSet<USoundModulatorBase> Modulators) {}
	///<summary>SetWet</summary>
	public  void SetWet(float WetAmount) {}
	///<summary>SetWetModulator</summary>
	public  void SetWetModulator(USoundModulatorBase Modulator) {}
	///<summary>SetWetModulators</summary>
	public  void SetWetModulators(TSet<USoundModulatorBase> Modulators) {}
	///<summary>SetDry</summary>
	public  void SetDry(float DryAmount) {}
	///<summary>SetDryModulator</summary>
	public  void SetDryModulator(USoundModulatorBase Modulator) {}
	///<summary>SetDryModulators</summary>
	public  void SetDryModulators(TSet<USoundModulatorBase> Modulators) {}
	///<summary>SetSpread</summary>
	public  void SetSpread(float Spread) {}
	///<summary>SetSpreadModulator</summary>
	public  void SetSpreadModulator(USoundModulatorBase Modulator) {}
	///<summary>SetSpreadModulators</summary>
	public  void SetSpreadModulators(TSet<USoundModulatorBase> Modulators) {}
	///<summary>Sets just base (i.e. carrier) setting values without modifying modulation source references</summary>
	public  void SetSettings(FSourceEffectChorusBaseSettings Settings) {}
	///<summary>SetModulationSettings</summary>
	public  void SetModulationSettings(FSourceEffectChorusSettings ModulationSettings) {}
	///<summary>Settings</summary>
	public FSourceEffectChorusSettings Settings;
}
