#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisasterRecoverySessionInfo.h")]
///<summary>Hold the information for multiple disaster recovery sessions.</summary>
public partial struct FDisasterRecoveryInfo {
// DisasterRecoveryInfo
	public uint Revision;
	public TArray<FDisasterRecoverySession> ActiveSessions;
	public TArray<FDisasterRecoverySession> RecentSessions;
	public TArray<FDisasterRecoverySession> ImportedSessions;
	public TArray<FDisasterRecoverySession> PendingSessions;
	public TArray<FGuid> DiscardedRepositoryIds;
	public TArray<FDisasterRecoveryClientInfo> Clients;
}
