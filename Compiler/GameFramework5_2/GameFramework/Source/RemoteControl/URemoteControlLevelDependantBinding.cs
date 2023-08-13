namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlBinding.h")]
public partial class URemoteControlLevelDependantBinding : URemoteControlBinding {
	public static UClass StaticClass() {return default;}
	///<summary>BoundObjectMap_DEPRECATED</summary>
	public TMap<TSoftObjectPtr<ULevel>,TSoftObjectPtr<UObject>> BoundObjectMap_DEPRECATED;
	///<summary>SubLevelSelectionMap_DEPRECATED</summary>
	public TMap<TSoftObjectPtr<UWorld>,TSoftObjectPtr<ULevel>> SubLevelSelectionMap_DEPRECATED;
	///<summary>The map bound objects with their level as key.</summary>
	public TMap<FSoftObjectPath,TSoftObjectPtr<UObject>> BoundObjectMapByPath;
	///<summary>Keeps track of which sublevel was last used when binding in a particular world.</summary>
	public TMap<FSoftObjectPath,TSoftObjectPtr<ULevel>> SubLevelSelectionMapByPath;
	///<summary>Caches the last level that had a successful resolve.</summary>
	public TSoftObjectPtr<ULevel> LevelWithLastSuccessfulResolve;
	///<summary>BindingContext</summary>
	public FRemoteControlInitialBindingContext BindingContext;
}
