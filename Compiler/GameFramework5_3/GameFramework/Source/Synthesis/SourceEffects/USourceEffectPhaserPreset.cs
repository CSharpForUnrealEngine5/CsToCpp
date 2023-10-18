namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceEffects/SourceEffectPhaser.h")]
public partial class USourceEffectPhaserPreset : USoundEffectSourcePreset {
	public static UClass StaticClass() {return default;}
	///<summary>SetSettings</summary>
	public void SetSettings(FSourceEffectPhaserSettings InSettings) {}
	///<summary>The depth of the chorus effect</summary>
	public FSourceEffectPhaserSettings Settings;
}
