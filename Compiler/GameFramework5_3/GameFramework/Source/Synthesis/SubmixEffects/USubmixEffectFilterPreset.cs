namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USubmixEffectFilterPreset</summary>
[CppInclude("SubmixEffects/SubmixEffectFilter.h")]
public partial class USubmixEffectFilterPreset : USoundEffectSubmixPreset {
	public static UClass StaticClass() {return default;}
	///<summary>Set all filter effect settings</summary>
	public void SetSettings(FSubmixEffectFilterSettings InSettings) {}
	///<summary>Sets the filter type</summary>
	public void SetFilterType(ESubmixFilterType InType) {}
	///<summary>Sets the filter algorithm</summary>
	public void SetFilterAlgorithm(ESubmixFilterAlgorithm InAlgorithm) {}
	///<summary>Sets the base filter cutoff frequency</summary>
	public void SetFilterCutoffFrequency(float InFrequency) {}
	///<summary>Sets the mod filter cutoff frequency</summary>
	public void SetFilterCutoffFrequencyMod(float InFrequency) {}
	///<summary>Sets the filter Q</summary>
	public void SetFilterQ(float InQ) {}
	///<summary>Sets the filter Q</summary>
	public void SetFilterQMod(float InQ) {}
	///<summary>Settings</summary>
	public FSubmixEffectFilterSettings Settings;
}
