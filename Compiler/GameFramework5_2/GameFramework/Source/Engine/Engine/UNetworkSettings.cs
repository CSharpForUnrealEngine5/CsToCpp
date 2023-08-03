#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Network settings.</summary>
[CppInclude("Engine/NetworkSettings.h")]
public partial class UNetworkSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>If true, libcurl authenticates the peer&#39;s certificate. Disable to allow self-signed certificates.</summary>
	public bool bVerifyPeer;
	///<summary>If true, origin rebasing is enabled in multiplayer games, meaning that servers and clients can have different local world origins.</summary>
	public bool bEnableMultiplayerWorldOriginRebasing;
	///<summary>This lists the common network emulation profiles that will be selectable in PIE settings</summary>
	public TArray<FNetworkEmulationProfileDescription> NetworkEmulationProfiles;
}
