#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An audio bus is an object which represents an audio patch cord. Audio can be sent to it. It can be sonified using USoundSourceBuses.</summary>
[CppInclude("Sound/AudioBus.h")]
public partial class UAudioBus : UObject {
	///<summary>Number of channels to use for the Audio Bus.</summary>
	public EAudioBusChannels AudioBusChannels;
}
