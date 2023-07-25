#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundSubmix.h")]
///<summary>Sound Submix class meant for sending soundfield-encoded audio to an external endpoint, such as a hardware binaural renderer that supports ambisonics.</summary>
public partial class USoundfieldEndpointSubmix : USoundSubmixBase {
// SoundfieldEndpointSubmix
	public string SoundfieldEndpointType;
	public UClass EndpointSettingsClass;
	public USoundfieldEndpointSettingsBase EndpointSettings;
	public UClass EncodingSettingsClass;
	public USoundfieldEncodingSettingsBase EncodingSettings;
	public TArray<USoundfieldEffectBase> SoundfieldEffectChain;
}
