namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USourceEffectMotionFilterPreset</summary>
[CppInclude("SourceEffects/SourceEffectMotionFilter.h")]
public partial class USourceEffectMotionFilterPreset : USoundEffectSourcePreset {
	public static UClass StaticClass() {return default;}
	///<summary>Change settings of your effect from blueprints. Will broadcast changes to active instances.</summary>
	public void SetSettings(FSourceEffectMotionFilterSettings InSettings) {}
	///<summary>The copy of the settings struct. Can&#39;t be written to in BP, but can be read.</summary>
	public FSourceEffectMotionFilterSettings Settings;
}
