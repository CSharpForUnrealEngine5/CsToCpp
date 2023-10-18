namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SynthComponents/EpicSynth1Component.h")]
public partial class UModularSynthLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Adds the modular synth preset to the bank asset in the content browser. Only call during editor.</summary>
	public static void AddModularSynthPresetToBankAsset(UModularSynthPresetBank InBank,FModularSynthPreset Preset,string PresetName) {}
}
