namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceEffects/SourceEffectPanner.h")]
public partial class USourceEffectPannerPreset : USoundEffectSourcePreset {
	public static UClass StaticClass() {return default;}
	///<summary>SetSettings</summary>
	public void SetSettings(FSourceEffectPannerSettings InSettings) {}
	///<summary>Settings</summary>
	public FSourceEffectPannerSettings Settings;
}
