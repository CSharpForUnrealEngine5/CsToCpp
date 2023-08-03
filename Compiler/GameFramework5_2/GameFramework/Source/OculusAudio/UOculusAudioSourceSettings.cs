#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusAudioSourceSettings.h")]
public partial class UOculusAudioSourceSettings : USpatializationPluginSourceSettingsBase {
	public static UClass StaticClass() {return default;}
	///<summary>EarlyReflectionsEnabled</summary>
	public bool EarlyReflectionsEnabled;
	///<summary>AttenuationEnabled</summary>
	public bool AttenuationEnabled;
	///<summary>AttenuationRangeMinimum</summary>
	public float AttenuationRangeMinimum;
	///<summary>AttenuationRangeMaximum</summary>
	public float AttenuationRangeMaximum;
	///<summary>VolumetricRadius</summary>
	public float VolumetricRadius;
	///<summary>ReverbSendLevel</summary>
	public float ReverbSendLevel;
}
