namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SynthComponents/EpicSynth1Component.h")]
public partial class UModularSynthPresetBank : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Presets</summary>
	public TArray<FModularSynthPresetBankEntry> Presets;
}
