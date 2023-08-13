namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sound Submix class meant for sending audio to an external endpoint, such as controller haptics or an additional audio device.</summary>
[CppInclude("Sound/SoundSubmix.h")]
public partial class UEndpointSubmix : USoundSubmixBase {
	public static UClass StaticClass() {return default;}
	///<summary>Currently used format.</summary>
	public string EndpointType;
	///<summary>EndpointSettingsClass</summary>
	public UClass EndpointSettingsClass;
	///<summary>EndpointSettings</summary>
	public UAudioEndpointSettingsBase EndpointSettings;
}
