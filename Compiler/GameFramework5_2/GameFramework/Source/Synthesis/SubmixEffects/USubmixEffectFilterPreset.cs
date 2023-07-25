#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubmixEffects/SubmixEffectFilter.h")]
///<summary>USubmixEffectFilterPreset</summary>
public partial class USubmixEffectFilterPreset : USoundEffectSubmixPreset {
// SubmixEffectFilterPreset
	public void SetSettings(FSubmixEffectFilterSettings InSettings) {}
	public void SetFilterType(ESubmixFilterType InType) {}
	public void SetFilterAlgorithm(ESubmixFilterAlgorithm InAlgorithm) {}
	public void SetFilterCutoffFrequency(float InFrequency) {}
	public void SetFilterCutoffFrequencyMod(float InFrequency) {}
	public void SetFilterQ(float InQ) {}
	public void SetFilterQMod(float InQ) {}
	public FSubmixEffectFilterSettings Settings;
}
