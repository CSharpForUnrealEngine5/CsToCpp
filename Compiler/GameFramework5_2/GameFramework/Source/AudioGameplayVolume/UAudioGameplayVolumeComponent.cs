namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UAudioGameplayVolumeComponent - Component used to drive interaction with AudioGameplayVolumeSubsystem.</summary>
[CppInclude("AudioGameplayVolumeComponent.h")]
public partial class UAudioGameplayVolumeComponent : UAudioGameplayComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Blueprint event for proxy enter</summary>
	public FOnAudioGameplayVolumeProxyStateChange OnProxyEnter;
	///<summary>Blueprint event for proxy exit</summary>
	public FOnAudioGameplayVolumeProxyStateChange OnProxyExit;
	///<summary>A representation of this volume for the audio thread</summary>
	public UAudioGameplayVolumeProxy Proxy;
}
