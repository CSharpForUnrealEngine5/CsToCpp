#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusAudioSourceSettings.h")]
public partial class UOculusAudioSourceSettings : USpatializationPluginSourceSettingsBase {
// OculusAudioSourceSettings
	public bool EarlyReflectionsEnabled;
	public bool AttenuationEnabled;
	public float AttenuationRangeMinimum;
	public float AttenuationRangeMaximum;
	public float VolumetricRadius;
	public float ReverbSendLevel;
}
