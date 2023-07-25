#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioGameplayVolumeComponent.h")]
///<summary>UAudioGameplayVolumeComponent - Component used to drive interaction with AudioGameplayVolumeSubsystem.</summary>
public partial class UAudioGameplayVolumeComponent : UAudioGameplayComponent {
// AudioGameplayVolumeComponent
	public FOnAudioGameplayVolumeProxyStateChange OnProxyEnter;
	public FOnAudioGameplayVolumeProxyStateChange OnProxyExit;
	public UAudioGameplayVolumeProxy Proxy;
}
