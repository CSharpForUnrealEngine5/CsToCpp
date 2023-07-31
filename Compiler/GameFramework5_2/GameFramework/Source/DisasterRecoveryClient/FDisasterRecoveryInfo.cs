#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Hold the information for multiple disaster recovery sessions.</summary>
[CppInclude("DisasterRecoverySessionInfo.h")]
public partial struct FDisasterRecoveryInfo {
	public uint Revision;
	public TArray<FDisasterRecoverySession> ActiveSessions;
	public TArray<FDisasterRecoverySession> RecentSessions;
	public TArray<FDisasterRecoverySession> ImportedSessions;
	public TArray<FDisasterRecoverySession> PendingSessions;
	public TArray<FGuid> DiscardedRepositoryIds;
	public TArray<FDisasterRecoveryClientInfo> Clients;
}
