#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisasterRecoverySettings.h")]
public partial class UDisasterRecoverClientConfig : UObject {
	///<summary>Enables Recovery Hub plugin to create and/or restore a recovery sessions when needed.</summary>
	public bool bIsEnabled;
	///<summary>The root directory where recovery sessions should be stored. If not set or</summary>
	public FDirectoryPath RecoverySessionDir;
	///<summary>The maximum number of recent recovery sessions to keep around. The sessions are rotated</summary>
	public int RecentSessionMaxCount;
	///<summary>The maximum number of imported recovery session to keep around. The sessions are rotated</summary>
	public int ImportedSessionMaxCount;
}
