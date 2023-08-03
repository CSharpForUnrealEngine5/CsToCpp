#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundSettings.h")]
public partial class UMetaSoundSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>If true, AutoUpdate is enabled, increasing load times.  If false, skips AutoUpdate on load, but can result in MetaSounds failing to load,</summary>
	public bool bAutoUpdateEnabled;
	///<summary>List of native MetaSound classes whose node references should not be AutoUpdated.</summary>
	public TArray<FMetasoundFrontendClassName> AutoUpdateDenylist;
	///<summary>List of MetaSound assets whose node references should not be AutoUpdated.</summary>
	public TArray<FDefaultMetaSoundAssetAutoUpdateSettings> AutoUpdateAssetDenylist;
	///<summary>If true, warnings will be logged if updating a node results in existing connections being discarded.</summary>
	public bool bAutoUpdateLogWarningOnDroppedConnection;
	///<summary>Directories to scan &amp; automatically register MetaSound post initial asset scan on engine start-up.</summary>
	public TArray<FDirectoryPath> DirectoriesToRegister;
	///<summary>DenyListCacheChangeID</summary>
	public int DenyListCacheChangeID;
}
