#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlBinding.h")]
public partial class URemoteControlLevelDependantBinding : URemoteControlBinding {
// RemoteControlLevelDependantBinding
	public TMap<TSoftObjectPtr<ULevel>,TSoftObjectPtr<UObject>> BoundObjectMap_DEPRECATED;
	public TMap<TSoftObjectPtr<UWorld>,TSoftObjectPtr<ULevel>> SubLevelSelectionMap_DEPRECATED;
	public TMap<FSoftObjectPath,TSoftObjectPtr<UObject>> BoundObjectMapByPath;
	public TMap<FSoftObjectPath,TSoftObjectPtr<ULevel>> SubLevelSelectionMapByPath;
	public TSoftObjectPtr<ULevel> LevelWithLastSuccessfulResolve;
	public FRemoteControlInitialBindingContext BindingContext;
}
