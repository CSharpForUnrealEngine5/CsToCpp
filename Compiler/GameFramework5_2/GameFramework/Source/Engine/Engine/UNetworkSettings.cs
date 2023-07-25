#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/NetworkSettings.h")]
///<summary>Network settings.</summary>
public partial class UNetworkSettings : UDeveloperSettings {
// NetworkSettings
	public bool bVerifyPeer;
	public bool bEnableMultiplayerWorldOriginRebasing;
	public TArray<FNetworkEmulationProfileDescription> NetworkEmulationProfiles;
}
