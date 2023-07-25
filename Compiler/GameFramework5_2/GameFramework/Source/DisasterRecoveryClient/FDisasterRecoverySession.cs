#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisasterRecoverySessionInfo.h")]
///<summary>Information about a single session info.</summary>
public partial struct FDisasterRecoverySession {
// DisasterRecoverySession
	public FGuid RepositoryId;
	public string RepositoryRootDir;
	public string SessionName;
	public uint MountedByProcessId;
	public uint ClientProcessId;
	public byte Flags;
}
