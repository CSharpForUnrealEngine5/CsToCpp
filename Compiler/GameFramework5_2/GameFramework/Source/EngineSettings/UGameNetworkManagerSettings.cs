#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameNetworkManagerSettings.h")]
///<summary>Holds the settings for the AGameNetworkManager class.</summary>
public partial class UGameNetworkManagerSettings : UObject {
// GameNetworkManagerSettings
	public int MinDynamicBandwidth;
	public int MaxDynamicBandwidth;
	public int TotalNetBandwidth;
	public int BadPingThreshold;
	public bool bIsStandbyCheckingEnabled;
	public float StandbyRxCheatTime;
	public float StandbyTxCheatTime;
	public float PercentMissingForRxStandby;
	public float PercentMissingForTxStandby;
	public float PercentForBadPing;
	public float JoinInProgressStandbyWaitTime;
}
