namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about a single session info.</summary>
[CppInclude("DisasterRecoverySessionInfo.h")]
public partial struct FDisasterRecoverySession {
	public FGuid RepositoryId;
	public string RepositoryRootDir;
	public string SessionName;
	public uint MountedByProcessId;
	public uint ClientProcessId;
	public byte Flags;
}
