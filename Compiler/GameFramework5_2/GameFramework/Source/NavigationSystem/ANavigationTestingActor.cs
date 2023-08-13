namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavigationTestingActor.h")]
public partial class ANavigationTestingActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>CapsuleComponent</summary>
	public UCapsuleComponent CapsuleComponent;
	///<summary>Editor Preview</summary>
	public UNavTestRenderingComponent EdRenderComp;
	///<summary>InvokerComponent</summary>
	public UNavigationInvokerComponent InvokerComponent;
	///<summary>bActAsNavigationInvoker</summary>
	public bool bActAsNavigationInvoker;
	///<summary>@todo document</summary>
	public FNavAgentProperties NavAgentProps;
	///<summary>QueryingExtent</summary>
	public FVector QueryingExtent;
	///<summary>MyNavData</summary>
	public ANavigationData MyNavData;
	///<summary>ProjectedLocation</summary>
	public FVector ProjectedLocation;
	///<summary>bProjectedLocationValid</summary>
	public bool bProjectedLocationValid;
	///<summary>if set, start the search from this actor, else start the search from the other actor</summary>
	public bool bSearchStart;
	///<summary>this multiplier is used to compute a max node cost allowed to the open list</summary>
	public float CostLimitFactor;
	///<summary>minimum cost limit clamping value (in cost units)</summary>
	public float MinimumCostLimit;
	///<summary>Instead of regular pathfinding from source to target location do</summary>
	public bool bBacktracking;
	///<summary>bUseHierarchicalPathfinding</summary>
	public bool bUseHierarchicalPathfinding;
	///<summary>if set, all steps of A* algorithm will be accessible for debugging</summary>
	public bool bGatherDetailedInfo;
	///<summary>if set, require the end location to be close to the navigation data. The tolerance is controlled by QueryingExtent</summary>
	public bool bRequireNavigableEndLocation;
	///<summary>bDrawDistanceToWall</summary>
	public bool bDrawDistanceToWall;
	///<summary>show polys from open (orange) and closed (yellow) sets</summary>
	public bool bShowNodePool;
	///<summary>show current best path</summary>
	public bool bShowBestPath;
	///<summary>show which nodes were modified in current A* step</summary>
	public bool bShowDiffWithPreviousStep;
	///<summary>bShouldBeVisibleInGame</summary>
	public bool bShouldBeVisibleInGame;
	///<summary>determines which cost will be shown</summary>
	public ENavCostDisplay CostDisplayMode;
	///<summary>text canvas offset to apply</summary>
	public FVector2D TextCanvasOffset;
	///<summary>bPathExist</summary>
	public bool bPathExist;
	///<summary>bPathIsPartial</summary>
	public bool bPathIsPartial;
	///<summary>bPathSearchOutOfNodes</summary>
	public bool bPathSearchOutOfNodes;
	///<summary>Time in micro seconds</summary>
	public float PathfindingTime;
	///<summary>PathCost</summary>
	public double PathCost;
	///<summary>PathfindingSteps</summary>
	public int PathfindingSteps;
	///<summary>OtherActor</summary>
	public ANavigationTestingActor OtherActor;
	///<summary>&quot;None&quot; will result in default filter being used</summary>
	public UClass FilterClass;
	///<summary>ShowStepIndex</summary>
	public int ShowStepIndex;
	///<summary>OffsetFromCornersDistance</summary>
	public float OffsetFromCornersDistance;
}
