#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Net/RPCDoSDetection.h")]
///<summary>Stores the RPC DoS detection state (either settings from the config file, or the active DDoS detection state)</summary>
public partial struct FRPCDoSState {
// RPCDoSState
	public bool bLogEscalate;
	public bool bSendEscalateAnalytics;
	public bool bKickPlayer;
	public bool bTrackRecentRPCs;
	public short EscalateQuotaRPCsPerFrame;
	public short EscalateTimeQuotaMSPerFrame;
	public short EscalateQuotaRPCsPerPeriod;
	public short EscalateTimeQuotaMSPerPeriod;
	public short EscalateQuotaTimePeriod;
	public short EscalationCountTolerance;
	public short EscalationTimeToleranceMS;
	public short RPCRepeatLimitPerPeriod;
	public short RPCRepeatLimitMSPerPeriod;
	public short RPCRepeatLimitTimePeriod;
	public short CooloffTime;
	public short AutoEscalateTime;
}
