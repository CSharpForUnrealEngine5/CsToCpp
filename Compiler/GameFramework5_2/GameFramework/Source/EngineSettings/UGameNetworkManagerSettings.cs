#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds the settings for the AGameNetworkManager class.</summary>
[CppInclude("GameNetworkManagerSettings.h")]
public partial class UGameNetworkManagerSettings : UObject {
	///<summary>Minimum bandwidth dynamically set per connection.</summary>
	public int MinDynamicBandwidth;
	///<summary>Maximum bandwidth dynamically set per connection.</summary>
	public int MaxDynamicBandwidth;
	///<summary>Total available bandwidth for listen server, split dynamically across net connections.</summary>
	public int TotalNetBandwidth;
	///<summary>The point we determine the server is either delaying packets or has bad upstream.</summary>
	public int BadPingThreshold;
	///<summary>Used to determine if checking for standby cheats should occur.</summary>
	public bool bIsStandbyCheckingEnabled;
	///<summary>The amount of time without packets before triggering the cheat code.</summary>
	public float StandbyRxCheatTime;
	///<summary>The amount of time without packets before triggering the cheat code.</summary>
	public float StandbyTxCheatTime;
	///<summary>The percentage of clients missing RX data before triggering the standby code.</summary>
	public float PercentMissingForRxStandby;
	///<summary>The percentage of clients missing TX data before triggering the standby code.</summary>
	public float PercentMissingForTxStandby;
	///<summary>The percentage of clients with bad ping before triggering the standby code.</summary>
	public float PercentForBadPing;
	///<summary>The amount of time to wait before checking a connection for standby issues.</summary>
	public float JoinInProgressStandbyWaitTime;
}
