#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavigationSystem.h")]
public partial class UNavigationSystemV1 : UNavigationSystemBase {
// NavigationSystemV1
	public ANavigationData MainNavData;
	public ANavigationData AbstractNavData;
	public string DefaultAgentName;
	public TSoftObjectPtr<UClass> CrowdManagerClass;
	public bool bAutoCreateNavigationData;
	public bool bSpawnNavDataInNavBoundsLevel;
	public bool bAllowClientSideNavigation;
	public bool bShouldDiscardSubLevelNavData;
	public bool bTickWhilePaused;
	public bool bSupportRebuilding;
	public bool bInitialBuildingLocked;
	public bool bSkipAgentHeightCheckWhenPickingNavData;
	public int GeometryExportTriangleCountWarningThreshold;
	public bool bGenerateNavigationOnlyAroundNavigationInvokers;
	public float ActiveTilesUpdateInterval;
	public ENavDataGatheringModeConfig DataGatheringMode;
	public float DirtyAreaWarningSizeThreshold;
	public float GatheringNavModifiersWarningLimitTime;
	public TArray<FNavDataConfig> SupportedAgents;
	public FNavAgentSelector SupportedAgentsMask;
	public FBox BuildBounds;
	public TArray<ANavigationData> NavDataSet;
	public TArray<ANavigationData> NavDataRegistrationQueue;
	public FOnNavDataGenericEvent OnNavDataRegisteredEvent;
	public FOnNavDataGenericEvent OnNavigationGenerationFinishedDelegate;
	public static UNavigationSystemV1 GetNavigationSystem(UObject WorldContextObject) { return default; }
	public static bool K2_ProjectPointToNavigation(UObject WorldContextObject,FVector Point,FVector ProjectedLocation,ANavigationData NavData,UClass FilterClass,FVector QueryExtent/*=FVector.ZeroVector*/) { return default; }
	public static bool K2_GetRandomReachablePointInRadius(UObject WorldContextObject,FVector Origin,FVector RandomLocation,float Radius,ANavigationData NavData/*=NULL*/,UClass FilterClass/*=NULL*/) { return default; }
	public static bool K2_GetRandomLocationInNavigableRadius(UObject WorldContextObject,FVector Origin,FVector RandomLocation,float Radius,ANavigationData NavData/*=NULL*/,UClass FilterClass/*=NULL*/) { return default; }
	public static ENavigationQueryResult GetPathCost(UObject WorldContextObject,FVector PathStart,FVector PathEnd,double PathCost,ANavigationData NavData/*=NULL*/,UClass FilterClass/*=NULL*/) { return default; }
	public static ENavigationQueryResult GetPathLength(UObject WorldContextObject,FVector PathStart,FVector PathEnd,double PathLength,ANavigationData NavData/*=NULL*/,UClass FilterClass/*=NULL*/) { return default; }
	public static bool IsNavigationBeingBuilt(UObject WorldContextObject) { return default; }
	public static bool IsNavigationBeingBuiltOrLocked(UObject WorldContextObject) { return default; }
	public static UNavigationPath FindPathToLocationSynchronously(UObject WorldContextObject,FVector PathStart,FVector PathEnd,AActor PathfindingContext/*=NULL*/,UClass FilterClass/*=NULL*/) { return default; }
	public static UNavigationPath FindPathToActorSynchronously(UObject WorldContextObject,FVector PathStart,AActor GoalActor,float TetherDistance/*=50.0f*/,AActor PathfindingContext/*=NULL*/,UClass FilterClass/*=NULL*/) { return default; }
	public static bool NavigationRaycast(UObject WorldContextObject,FVector RayStart,FVector RayEnd,FVector HitLocation,UClass FilterClass/*=NULL*/,AController Querier/*=NULL*/) { return default; }
	public  void SetMaxSimultaneousTileGenerationJobsCount(int MaxNumberOfJobs) {}
	public  void ResetMaxSimultaneousTileGenerationJobsCount() {}
	public  void RegisterNavigationInvoker(AActor Invoker,float TileGenerationRadius/*=3000f*/,float TileRemovalRadius/*=5000f*/) {}
	public  void UnregisterNavigationInvoker(AActor Invoker) {}
	public  void SetGeometryGatheringMode(ENavDataGatheringModeConfig NewMode) {}
	public  bool K2_ReplaceAreaInOctreeData(UObject Object,UClass OldArea,UClass NewArea) { return default; }
	public  void OnNavigationBoundsUpdated(ANavMeshBoundsVolume NavVolume) {}
	public FNavigationSystemRunMode OperationMode;
	public static bool K2_GetRandomPointInNavigableRadius(UObject WorldContextObject,FVector Origin,FVector RandomLocation,float Radius,ANavigationData NavData/*=NULL*/,UClass FilterClass/*=NULL*/) { return default; }
}
