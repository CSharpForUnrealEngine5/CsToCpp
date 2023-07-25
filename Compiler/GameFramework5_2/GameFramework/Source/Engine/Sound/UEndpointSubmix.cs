#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundSubmix.h")]
///<summary>Sound Submix class meant for sending audio to an external endpoint, such as controller haptics or an additional audio device.</summary>
public partial class UEndpointSubmix : USoundSubmixBase {
// EndpointSubmix
	public string EndpointType;
	public UClass EndpointSettingsClass;
	public UAudioEndpointSettingsBase EndpointSettings;
}
