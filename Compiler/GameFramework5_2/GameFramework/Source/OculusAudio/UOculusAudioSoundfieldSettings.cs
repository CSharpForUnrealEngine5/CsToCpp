namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusAmbisonicsSettings.h")]
public partial class UOculusAudioSoundfieldSettings : USoundfieldEncodingSettingsBase {
	public static UClass StaticClass() {return default;}
	///<summary>SpatializationMode</summary>
	public EOculusAudioAmbisonicsMode SpatializationMode;
}
