#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Engine.h")]
///<summary>FWorldContext</summary>
public partial struct FWorldContext {
// WorldContext
	public FURL LastURL;
	public FURL LastRemoteURL;
	public UPendingNetGame PendingNetGame;
	public TArray<FFullyLoadedPackagesInfo> PackagesToFullyLoad;
	public TArray<ULevel> LoadedLevelsForPendingMapChange;
	public TArray<UObjectReferencer> ObjectReferencers;
	public TArray<FLevelStreamingStatus> PendingLevelStreamingStatusUpdates;
	public UGameViewportClient GameViewport;
	public UGameInstance OwningGameInstance;
	public TArray<FNamedNetDriver> ActiveNetDrivers;
}
