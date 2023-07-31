#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FWorldContext</summary>
[CppInclude("Engine/Engine.h")]
public partial struct FWorldContext {
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
