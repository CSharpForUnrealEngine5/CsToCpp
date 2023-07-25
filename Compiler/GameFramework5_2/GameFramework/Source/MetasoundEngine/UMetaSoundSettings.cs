#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundSettings.h")]
public partial class UMetaSoundSettings : UDeveloperSettings {
// MetaSoundSettings
	public bool bAutoUpdateEnabled;
	public TArray<FMetasoundFrontendClassName> AutoUpdateDenylist;
	public TArray<FDefaultMetaSoundAssetAutoUpdateSettings> AutoUpdateAssetDenylist;
	public bool bAutoUpdateLogWarningOnDroppedConnection;
	public TArray<FDirectoryPath> DirectoriesToRegister;
	public int DenyListCacheChangeID;
}
