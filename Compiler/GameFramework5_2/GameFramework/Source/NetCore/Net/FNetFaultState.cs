#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Net/Core/Connection/NetConnectionFaultRecoveryBase.h")]
///<summary>Generic escalation state definition used to implement attempted recovery from faults/errors in the NetConnection level netcode.</summary>
public partial struct FNetFaultState {
// NetFaultState
	public bool bCloseConnection;
	public short EscalateQuotaFaultsPerPeriod;
	public short EscalateQuotaFaultPercentPerPeriod;
	public short DescalateQuotaFaultsPerPeriod;
	public short DescalateQuotaFaultPercentPerPeriod;
	public short EscalateQuotaTimePeriod;
}
