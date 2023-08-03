#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles game-specific networking management (cheat detection, bandwidth management, etc.).</summary>
[CppInclude("GameFramework/GameNetworkManager.h")]
public partial class AGameNetworkManager : AInfo {
	public static UClass StaticClass() {return default;}
	///<summary>If packet loss goes over this value, we have bad packet loss. Value is between 0 and 1.</summary>
	public float BadPacketLossThreshold;
	///<summary>If the packet loss goes over this threshold, we have severe packet loss. Value is between 0 and 1</summary>
	public float SeverePacketLossThreshold;
	///<summary>If average ping is higher than this threshold in ms, determine the server is either delaying packets or has bad upstream.</summary>
	public int BadPingThreshold;
	///<summary>Similar to BadPingThreshold, but used to track exceptionally bad pings.</summary>
	public int SeverePingThreshold;
	///<summary>Current adjusted bandwidth per player, based on total and dynamic bandwidth</summary>
	public int AdjustedNetSpeed;
	///<summary>Last time AdjustedNetSpeed was updated for server (by client entering or leaving)</summary>
	public float LastNetSpeedUpdateTime;
	///<summary>Total available bandwidth (in bytes/sec) for listen server, split dynamically across net connections</summary>
	public int TotalNetBandwidth;
	///<summary>Minimum bandwidth set per connection after splitting TotalNetBandwidth</summary>
	public int MinDynamicBandwidth;
	///<summary>Maximum bandwidth set per connection after splitting TotalNetBandwidth</summary>
	public int MaxDynamicBandwidth;
	///<summary>Used to determine if checking for standby cheats should occur</summary>
	public bool bIsStandbyCheckingEnabled;
	///<summary>Used to determine whether we&#39;ve already caught a cheat or not</summary>
	public bool bHasStandbyCheatTriggered;
	///<summary>The amount of time without packets before triggering the cheat code</summary>
	public float StandbyRxCheatTime;
	///<summary>The amount of time without packets before triggering the cheat code</summary>
	public float StandbyTxCheatTime;
	///<summary>The percentage of clients missing RX data before triggering the standby code</summary>
	public float PercentMissingForRxStandby;
	///<summary>The percentage of clients missing TX data before triggering the standby code</summary>
	public float PercentMissingForTxStandby;
	///<summary>The percentage of clients with bad ping before triggering the standby code</summary>
	public float PercentForBadPing;
	///<summary>The amount of time to wait before checking a connection for standby issues</summary>
	public float JoinInProgressStandbyWaitTime;
	///<summary>Average size of replicated move packet (ServerMove() packet size) from player</summary>
	public float MoveRepSize;
	///<summary>MAXPOSITIONERRORSQUARED is the square of the max position error that is accepted (not corrected) in net play</summary>
	public float MAXPOSITIONERRORSQUARED;
	///<summary>MAXNEARZEROVELOCITYSQUARED is the square of the max velocity that is considered zero (not corrected) in net play</summary>
	public float MAXNEARZEROVELOCITYSQUARED;
	///<summary>CLIENTADJUSTUPDATECOST is the bandwidth cost in bytes of sending a client adjustment update. 180 is greater than the actual cost, but represents a tweaked value reserving enough bandwidth for</summary>
	public float CLIENTADJUSTUPDATECOST;
	///<summary>MAXCLIENTUPDATEINTERVAL is the maximum time between movement updates from the client before the server forces an update.</summary>
	public float MAXCLIENTUPDATEINTERVAL;
	///<summary>MaxClientForcedUpdateDuration is the maximum time duration over which the server will force updates, after MAXCLIENTUPDATEINTERVAL is initially exceeded.</summary>
	public float MaxClientForcedUpdateDuration;
	///<summary>Ignore forced client movement updates when server hitches for longer than this duration.</summary>
	public float ServerForcedUpdateHitchThreshold;
	///<summary>Ignore forced client movement updates when server hitch was detected within this amount of time in the past.</summary>
	public float ServerForcedUpdateHitchCooldown;
	///<summary>MaxMoveDeltaTime is the default maximum time delta of CharacterMovement ServerMoves. Should be less than or equal to MAXCLIENTUPDATEINTERVAL, otherwise server will interfere by forcing position updates.</summary>
	public float MaxMoveDeltaTime;
	///<summary>MaxClientSmoothingDeltaTime is the maximum delta time between server updates that clients are allowed to smooth between for position interpolation. This was previously (2 * MaxMoveDeltaTime).</summary>
	public float MaxClientSmoothingDeltaTime;
	///<summary>ClientNetSendMoveDeltaTime is the default minimum time delta of CharacterMovement client moves to the server. When updates occur more frequently, they may be combined to save bandwidth.</summary>
	public float ClientNetSendMoveDeltaTime;
	///<summary>ClientNetSendMoveDeltaTimeThrottled is used in place of ClientNetSendMoveDeltaTime when player count is high or net speed is low. See ClientNetSendMoveDeltaTime for more info.</summary>
	public float ClientNetSendMoveDeltaTimeThrottled;
	///<summary>ClientNetSendMoveDeltaTimeStationary is used when players are determined to not be moving or changing their view. See ClientNetSendMoveDeltaTime for more info.</summary>
	public float ClientNetSendMoveDeltaTimeStationary;
	///<summary>When player net speed (CurrentNetSpeed, based on ConfiguredInternetSpeed or ConfiguredLanSpeed) is less than or equal to this amount, ClientNetSendMoveDeltaTimeThrottled is used instead of ClientNetSendMoveDeltaTime.</summary>
	public int ClientNetSendMoveThrottleAtNetSpeed;
	///<summary>When player count is greater than this amount, ClientNetSendMoveDeltaTimeThrottled is used instead of ClientNetSendMoveDeltaTime.</summary>
	public int ClientNetSendMoveThrottleOverPlayerCount;
	///<summary>Minimum delay between the server sending error corrections to a client, in seconds.</summary>
	public float ClientErrorUpdateRateLimit;
	///<summary>Minimum delay between calls to ServerUpdateCamera, in seconds.</summary>
	public float ClientNetCamUpdateDeltaTime;
	///<summary>Camera position change limit, when exceeded allows an immediate ServerUpdateCamera call.</summary>
	public float ClientNetCamUpdatePositionLimit;
	///<summary>If client update is within MAXPOSITIONERRORSQUARED of what the server expects then the client is authoritative on it&#39;s final position</summary>
	public bool ClientAuthorativePosition;
	///<summary>Whether movement time discrepancy (speed hack) detection is enabled.</summary>
	public bool bMovementTimeDiscrepancyDetection;
	///<summary>Whether movement time discrepancy resolution is enabled (when detected, make client movement &quot;pay back&quot; excessive time discrepancies)</summary>
	public bool bMovementTimeDiscrepancyResolution;
	///<summary>Maximum time client can be ahead before triggering movement time discrepancy detection/resolution (if enabled).</summary>
	public float MovementTimeDiscrepancyMaxTimeMargin;
	///<summary>Maximum time client can be behind.</summary>
	public float MovementTimeDiscrepancyMinTimeMargin;
	///<summary>During time discrepancy resolution, we &quot;pay back&quot; the time discrepancy at this rate for future moves until total error is zero.</summary>
	public float MovementTimeDiscrepancyResolutionRate;
	///<summary>Accepted drift in clocks between client and server as a percent per second allowed.</summary>
	public float MovementTimeDiscrepancyDriftAllowance;
	///<summary>Whether client moves should be force corrected during time discrepancy resolution, useful for projects that have lenient</summary>
	public bool bMovementTimeDiscrepancyForceCorrectionsDuringResolution;
	///<summary>If true, actor network relevancy is constrained by whether they are within their NetCullDistanceSquared from the client&#39;s view point.</summary>
	public bool bUseDistanceBasedRelevancy;
}
