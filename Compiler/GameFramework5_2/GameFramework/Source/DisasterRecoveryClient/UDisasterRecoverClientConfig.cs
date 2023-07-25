#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisasterRecoverySettings.h")]
public partial class UDisasterRecoverClientConfig : UObject {
// DisasterRecoverClientConfig
	public bool bIsEnabled;
	public FDirectoryPath RecoverySessionDir;
	public int RecentSessionMaxCount;
	public int ImportedSessionMaxCount;
}
