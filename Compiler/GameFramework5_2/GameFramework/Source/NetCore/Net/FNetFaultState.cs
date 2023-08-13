namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generic escalation state definition used to implement attempted recovery from faults/errors in the NetConnection level netcode.</summary>
[CppInclude("Net/Core/Connection/NetConnectionFaultRecoveryBase.h")]
public partial struct FNetFaultState {
	public bool bCloseConnection;
	public short EscalateQuotaFaultsPerPeriod;
	public short EscalateQuotaFaultPercentPerPeriod;
	public short DescalateQuotaFaultsPerPeriod;
	public short DescalateQuotaFaultPercentPerPeriod;
	public short EscalateQuotaTimePeriod;
}
