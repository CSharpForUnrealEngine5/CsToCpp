#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubmixEffects/SubmixEffectMultiBandCompressor.h")]
public partial class USubmixEffectMultibandCompressorPreset : USoundEffectSubmixPreset {
	public static UClass StaticClass() {return default;}
	///<summary>ResetKey</summary>
	public  void ResetKey() {}
	///<summary>Sets the source key input as the provided AudioBus&#39; output.  If no object is provided, key is set</summary>
	public  void SetAudioBus(UAudioBus AudioBus) {}
	///<summary>Sets the source key input as the provided Submix&#39;s output.  If no object is provided, key is set</summary>
	public  void SetExternalSubmix(USoundSubmix Submix) {}
	///<summary>SetSettings</summary>
	public  void SetSettings(FSubmixEffectMultibandCompressorSettings InSettings) {}
	///<summary>Settings</summary>
	public FSubmixEffectMultibandCompressorSettings Settings;
}
