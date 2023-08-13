namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavigationSystem.h")]
public partial class UNavigationSystemV1 : UNavigationSystemBase {
	public static UClass StaticClass() {return default;}
	///<summary>MainNavData</summary>
	public ANavigationData MainNavData;
	///<summary>special navigation data for managing direct paths, not part of NavDataSet!</summary>
	public ANavigationData AbstractNavData;
	///<summary>If not None indicates which of navigation datas and supported agents are</summary>
	public string DefaultAgentName;
	///<summary>CrowdManagerClass</summary>
	public TSoftObjectPtr<UClass> CrowdManagerClass;
	///<summary>Should navigation system spawn default Navigation Data when there&#39;s none and there are navigation bounds present?</summary>
	public bool bAutoCreateNavigationData;
	///<summary>If true will try to spawn the navigation data instance in the sublevel with navigation bounds, if false it will spawn in the persistent level</summary>
	public bool bSpawnNavDataInNavBoundsLevel;
	///<summary>If false, will not create nav collision when connecting as a client</summary>
	public bool bAllowClientSideNavigation;
	///<summary>If true, games should ignore navigation data inside loaded sublevels</summary>
	public bool bShouldDiscardSubLevelNavData;
	///<summary>If true, will update navigation even when the game is paused</summary>
	public bool bTickWhilePaused;
	///<summary>gets set to true if gathering navigation data (like in navoctree) is required due to the need of navigation generation</summary>
	public bool bSupportRebuilding;
	///<summary>if set to true will result navigation system not rebuild navigation until</summary>
	public bool bInitialBuildingLocked;
	///<summary>false by default, if set to true will result in not caring about nav agent height</summary>
	public bool bSkipAgentHeightCheckWhenPickingNavData;
	///<summary>Warnings are logged if exporting the navigation collision for an object exceed this triangle count.</summary>
	public int GeometryExportTriangleCountWarningThreshold;
	///<summary>If set to true navigation will be generated only around registered &quot;navigation enforcers&quot;</summary>
	public bool bGenerateNavigationOnlyAroundNavigationInvokers;
	///<summary>Minimal time, in seconds, between active tiles set update</summary>
	public float ActiveTilesUpdateInterval;
	///<summary>Sets how navigation data should be gathered when building collision information</summary>
	public ENavDataGatheringModeConfig DataGatheringMode;
	///<summary>-1 by default, if set to a positive value dirty areas with any dimensions in 2d over the threshold created at runtime will be logged</summary>
	public float DirtyAreaWarningSizeThreshold;
	///<summary>-1.0f by default, if set to a positive value, all calls to GetNavigationData will be timed and compared to it.</summary>
	public float GatheringNavModifiersWarningLimitTime;
	///<summary>List of agents types supported by this navigation system</summary>
	public TArray<FNavDataConfig> SupportedAgents;
	///<summary>NavigationSystem&#39;s properties in Project Settings define all possible supported agents,</summary>
	public FNavAgentSelector SupportedAgentsMask;
	///<summary>Bounds of tiles to be built</summary>
	public FBox BuildBounds;
	///<summary>NavDataSet</summary>
	public TArray<ANavigationData> NavDataSet;
	///<summary>NavDataRegistrationQueue</summary>
	public TArray<ANavigationData> NavDataRegistrationQueue;
	///<summary>BlueprintAssignable,</summary>
	public FOnNavDataGenericEvent OnNavDataRegisteredEvent;
	///<summary>OnNavigationGenerationFinishedDelegate</summary>
	public FOnNavDataGenericEvent OnNavigationGenerationFinishedDelegate;
	///<summary>Blueprint functions</summary>
	public static UNavigationSystemV1 GetNavigationSystem(UObject WorldContextObject) { return default; }
	///<summary>Project a point onto the NavigationData</summary>
	public static bool K2_ProjectPointToNavigation(UObject WorldContextObject,FVector Point,FVector ProjectedLocation,ANavigationData NavData,UClass FilterClass,FVector QueryExtent/*=FVector.ZeroVector*/) { return default; }
	///<summary>Generates a random location reachable from given Origin location.</summary>
	public static bool K2_GetRandomReachablePointInRadius(UObject WorldContextObject,FVector Origin,FVector RandomLocation,float Radius,ANavigationData NavData/*=NULL*/,UClass FilterClass/*=NULL*/) { return default; }
	///<summary>Generates a random location in navigable space within given radius of Origin.</summary>
	public static bool K2_GetRandomLocationInNavigableRadius(UObject WorldContextObject,FVector Origin,FVector RandomLocation,float Radius,ANavigationData NavData/*=NULL*/,UClass FilterClass/*=NULL*/) { return default; }
	///<summary>Potentially expensive. Use with caution. Consider using UPathFollowingComponent::GetRemainingPathCost instead</summary>
	public static ENavigationQueryResult GetPathCost(UObject WorldContextObject,FVector PathStart,FVector PathEnd,double PathCost,ANavigationData NavData/*=NULL*/,UClass FilterClass/*=NULL*/) { return default; }
	///<summary>Potentially expensive. Use with caution</summary>
	public static ENavigationQueryResult GetPathLength(UObject WorldContextObject,FVector PathStart,FVector PathEnd,double PathLength,ANavigationData NavData/*=NULL*/,UClass FilterClass/*=NULL*/) { return default; }
	///<summary>IsNavigationBeingBuilt</summary>
	public static bool IsNavigationBeingBuilt(UObject WorldContextObject) { return default; }
	///<summary>IsNavigationBeingBuiltOrLocked</summary>
	public static bool IsNavigationBeingBuiltOrLocked(UObject WorldContextObject) { return default; }
	///<summary>Finds path instantly, in a FindPath Synchronously.</summary>
	public static UNavigationPath FindPathToLocationSynchronously(UObject WorldContextObject,FVector PathStart,FVector PathEnd,AActor PathfindingContext/*=NULL*/,UClass FilterClass/*=NULL*/) { return default; }
	///<summary>Finds path instantly, in a FindPath Synchronously. Main advantage over FindPathToLocationSynchronously is that</summary>
	public static UNavigationPath FindPathToActorSynchronously(UObject WorldContextObject,FVector PathStart,AActor GoalActor,float TetherDistance/*=50.0f*/,AActor PathfindingContext/*=NULL*/,UClass FilterClass/*=NULL*/) { return default; }
	///<summary>Performs navigation raycast on NavigationData appropriate for given Querier.</summary>
	public static bool NavigationRaycast(UObject WorldContextObject,FVector RayStart,FVector RayEnd,FVector HitLocation,UClass FilterClass/*=NULL*/,AController Querier/*=NULL*/) { return default; }
	///<summary>will limit the number of simultaneously running navmesh tile generation jobs to specified number.</summary>
	public void SetMaxSimultaneousTileGenerationJobsCount(int MaxNumberOfJobs) {}
	///<summary>Brings limit of simultaneous navmesh tile generation jobs back to Project Setting&#39;s default value</summary>
	public void ResetMaxSimultaneousTileGenerationJobsCount() {}
	///<summary>Registers given actor as a &quot;navigation enforcer&quot; which means navigation system will</summary>
	public void RegisterNavigationInvoker(AActor Invoker,float TileGenerationRadius/*=3000f*/,float TileRemovalRadius/*=5000f*/) {}
	///<summary>Removes given actor from the list of active navigation enforcers.</summary>
	public void UnregisterNavigationInvoker(AActor Invoker) {}
	///<summary>SetGeometryGatheringMode</summary>
	public void SetGeometryGatheringMode(ENavDataGatheringModeConfig NewMode) {}
	///<summary>K2_ReplaceAreaInOctreeData</summary>
	public bool K2_ReplaceAreaInOctreeData(UObject Object,UClass OldArea,UClass NewArea) { return default; }
	///<summary>@todo document</summary>
	public void OnNavigationBoundsUpdated(ANavMeshBoundsVolume NavVolume) {}
	///<summary>OperationMode</summary>
	public FNavigationSystemRunMode OperationMode;
	///<summary>K2_GetRandomPointInNavigableRadius</summary>
	public static bool K2_GetRandomPointInNavigableRadius(UObject WorldContextObject,FVector Origin,FVector RandomLocation,float Radius,ANavigationData NavData/*=NULL*/,UClass FilterClass/*=NULL*/) { return default; }
}
