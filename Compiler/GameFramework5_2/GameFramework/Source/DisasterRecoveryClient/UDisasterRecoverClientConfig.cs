namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisasterRecoverySettings.h")]
public partial class UDisasterRecoverClientConfig : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Enables Recovery Hub plugin to create and/or restore a recovery sessions when needed.</summary>
	public bool bIsEnabled;
	///<summary>The root directory where recovery sessions should be stored. If not set or</summary>
	public FDirectoryPath RecoverySessionDir;
	///<summary>The maximum number of recent recovery sessions to keep around. The sessions are rotated</summary>
	public int RecentSessionMaxCount;
	///<summary>The maximum number of imported recovery session to keep around. The sessions are rotated</summary>
	public int ImportedSessionMaxCount;
}
