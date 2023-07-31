#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USourceEffectMidSideSpreaderPreset</summary>
[CppInclude("SourceEffects/SourceEffectMidSideSpreader.h")]
public partial class USourceEffectMidSideSpreaderPreset : USoundEffectSourcePreset {
	///<summary>Change settings of your effect from blueprints. Will broadcast changes to active instances.</summary>
	public  void SetSettings(FSourceEffectMidSideSpreaderSettings InSettings) {}
	///<summary>The copy of the settings struct. Can&#39;t be written to in BP, but can be read.</summary>
	public FSourceEffectMidSideSpreaderSettings Settings;
}
