#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundAttenuation.h")]
public partial struct FSoundAttenuationPluginSettings {
// SoundAttenuationPluginSettings
	public TArray<USpatializationPluginSourceSettingsBase> SpatializationPluginSettingsArray;
	public TArray<UOcclusionPluginSourceSettingsBase> OcclusionPluginSettingsArray;
	public TArray<UReverbPluginSourceSettingsBase> ReverbPluginSettingsArray;
	public TArray<USourceDataOverridePluginSourceSettingsBase> SourceDataOverridePluginSettingsArray;
}
