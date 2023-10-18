namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceEffects/SourceEffectWaveShaper.h")]
public partial class USourceEffectWaveShaperPreset : USoundEffectSourcePreset {
	public static UClass StaticClass() {return default;}
	///<summary>SetSettings</summary>
	public void SetSettings(FSourceEffectWaveShaperSettings InSettings) {}
	///<summary>Settings</summary>
	public FSourceEffectWaveShaperSettings Settings;
}
