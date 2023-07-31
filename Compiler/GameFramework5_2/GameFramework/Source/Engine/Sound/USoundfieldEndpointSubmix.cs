#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sound Submix class meant for sending soundfield-encoded audio to an external endpoint, such as a hardware binaural renderer that supports ambisonics.</summary>
[CppInclude("Sound/SoundSubmix.h")]
public partial class USoundfieldEndpointSubmix : USoundSubmixBase {
	///<summary>Currently used format.</summary>
	public string SoundfieldEndpointType;
	///<summary>EndpointSettingsClass</summary>
	public UClass EndpointSettingsClass;
	///<summary>EndpointSettings</summary>
	public USoundfieldEndpointSettingsBase EndpointSettings;
	///<summary>EncodingSettingsClass</summary>
	public UClass EncodingSettingsClass;
	///<summary>EncodingSettings</summary>
	public USoundfieldEncodingSettingsBase EncodingSettings;
	///<summary>SoundfieldEffectChain</summary>
	public TArray<USoundfieldEffectBase> SoundfieldEffectChain;
}
