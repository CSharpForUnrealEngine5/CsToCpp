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
	public UObject GetNavigationSystem(UObject WorldContextObject) { return default; }
	public bool K2_ProjectPointToNavigation(UObject WorldContextObject,FVector Point,FVector ProjectedLocation,UObject NavData,UClass FilterClass,FVector QueryExtent/*=FVector.ZeroVector*/) { return default; }
	public bool K2_GetRandomReachablePointInRadius(UObject WorldContextObject,FVector Origin,FVector RandomLocation,float Radius,UObject NavData/*=NULL*/,UClass FilterClass/*=NULL*/) { return default; }
	public bool K2_GetRandomLocationInNavigableRadius(UObject WorldContextObject,FVector Origin,FVector RandomLocation,float Radius,UObject NavData/*=NULL*/,UClass FilterClass/*=NULL*/) { return default; }
	public ENavigationQueryResult GetPathCost(UObject WorldContextObject,FVector PathStart,FVector PathEnd,double PathCost,UObject NavData/*=NULL*/,UClass FilterClass/*=NULL*/) { return default; }
	public ENavigationQueryResult GetPathLength(UObject WorldContextObject,FVector PathStart,FVector PathEnd,double PathLength,UObject NavData/*=NULL*/,UClass FilterClass/*=NULL*/) { return default; }
	public bool IsNavigationBeingBuilt(UObject WorldContextObject) { return default; }
	public bool IsNavigationBeingBuiltOrLocked(UObject WorldContextObject) { return default; }
	public UObject FindPathToLocationSynchronously(UObject WorldContextObject,FVector PathStart,FVector PathEnd,UObject PathfindingContext/*=NULL*/,UClass FilterClass/*=NULL*/) { return default; }
	public UObject FindPathToActorSynchronously(UObject WorldContextObject,FVector PathStart,UObject GoalActor,float TetherDistance/*=50.0f*/,UObject PathfindingContext/*=NULL*/,UClass FilterClass/*=NULL*/) { return default; }
	public bool NavigationRaycast(UObject WorldContextObject,FVector RayStart,FVector RayEnd,FVector HitLocation,UClass FilterClass/*=NULL*/,UObject Querier/*=NULL*/) { return default; }
	public void SetMaxSimultaneousTileGenerationJobsCount(int MaxNumberOfJobs) {}
	public void ResetMaxSimultaneousTileGenerationJobsCount() {}
	public void RegisterNavigationInvoker(UObject Invoker,float TileGenerationRadius/*=3000f*/,float TileRemovalRadius/*=5000f*/) {}
	public void UnregisterNavigationInvoker(UObject Invoker) {}
	public void SetGeometryGatheringMode(ENavDataGatheringModeConfig NewMode) {}
	public bool K2_ReplaceAreaInOctreeData(UObject Object,UClass OldArea,UClass NewArea) { return default; }
	public void OnNavigationBoundsUpdated(UObject NavVolume) {}
	public FNavigationSystemRunMode OperationMode;
	public bool K2_GetRandomPointInNavigableRadius(UObject WorldContextObject,FVector Origin,FVector RandomLocation,float Radius,UObject NavData/*=NULL*/,UClass FilterClass/*=NULL*/) { return default; }
}
