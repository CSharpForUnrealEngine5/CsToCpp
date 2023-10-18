namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ResonanceAudioAmbisonicsSettings.h")]
public partial class UResonanceAudioSoundfieldSettings : USoundfieldEncodingSettingsBase {
	public static UClass StaticClass() {return default;}
	///<summary>Which order of ambisonics to use for this submix.</summary>
	public EResonanceRenderMode RenderMode;
}
