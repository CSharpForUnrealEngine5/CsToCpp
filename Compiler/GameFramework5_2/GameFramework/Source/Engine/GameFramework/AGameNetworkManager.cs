#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/GameNetworkManager.h")]
///<summary>Handles game-specific networking management (cheat detection, bandwidth management, etc.).</summary>
public partial class AGameNetworkManager : AInfo {
// GameNetworkManager
	public float BadPacketLossThreshold;
	public float SeverePacketLossThreshold;
	public int BadPingThreshold;
	public int SeverePingThreshold;
	public int AdjustedNetSpeed;
	public float LastNetSpeedUpdateTime;
	public int TotalNetBandwidth;
	public int MinDynamicBandwidth;
	public int MaxDynamicBandwidth;
	public bool bIsStandbyCheckingEnabled;
	public bool bHasStandbyCheatTriggered;
	public float StandbyRxCheatTime;
	public float StandbyTxCheatTime;
	public float PercentMissingForRxStandby;
	public float PercentMissingForTxStandby;
	public float PercentForBadPing;
	public float JoinInProgressStandbyWaitTime;
	public float MoveRepSize;
	public float MAXPOSITIONERRORSQUARED;
	public float MAXNEARZEROVELOCITYSQUARED;
	public float CLIENTADJUSTUPDATECOST;
	public float MAXCLIENTUPDATEINTERVAL;
	public float MaxClientForcedUpdateDuration;
	public float ServerForcedUpdateHitchThreshold;
	public float ServerForcedUpdateHitchCooldown;
	public float MaxMoveDeltaTime;
	public float MaxClientSmoothingDeltaTime;
	public float ClientNetSendMoveDeltaTime;
	public float ClientNetSendMoveDeltaTimeThrottled;
	public float ClientNetSendMoveDeltaTimeStationary;
	public int ClientNetSendMoveThrottleAtNetSpeed;
	public int ClientNetSendMoveThrottleOverPlayerCount;
	public float ClientErrorUpdateRateLimit;
	public float ClientNetCamUpdateDeltaTime;
	public float ClientNetCamUpdatePositionLimit;
	public bool ClientAuthorativePosition;
	public bool bMovementTimeDiscrepancyDetection;
	public bool bMovementTimeDiscrepancyResolution;
	public float MovementTimeDiscrepancyMaxTimeMargin;
	public float MovementTimeDiscrepancyMinTimeMargin;
	public float MovementTimeDiscrepancyResolutionRate;
	public float MovementTimeDiscrepancyDriftAllowance;
	public bool bMovementTimeDiscrepancyForceCorrectionsDuringResolution;
	public bool bUseDistanceBasedRelevancy;
}
