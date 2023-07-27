#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavigationTestingActor.h")]
public partial class ANavigationTestingActor : AActor {
// NavigationTestingActor
	public UCapsuleComponent CapsuleComponent;
	public UNavTestRenderingComponent EdRenderComp;
	public UNavigationInvokerComponent InvokerComponent;
	public bool bActAsNavigationInvoker;
	public FNavAgentProperties NavAgentProps;
	public FVector QueryingExtent;
	public ANavigationData MyNavData;
	public FVector ProjectedLocation;
	public bool bProjectedLocationValid;
	public bool bSearchStart;
	public float CostLimitFactor;
	public float MinimumCostLimit;
	public bool bBacktracking;
	public bool bUseHierarchicalPathfinding;
	public bool bGatherDetailedInfo;
	public bool bRequireNavigableEndLocation;
	public bool bDrawDistanceToWall;
	public bool bShowNodePool;
	public bool bShowBestPath;
	public bool bShowDiffWithPreviousStep;
	public bool bShouldBeVisibleInGame;
	public ENavCostDisplay CostDisplayMode;
	public FVector2D TextCanvasOffset;
	public bool bPathExist;
	public bool bPathIsPartial;
	public bool bPathSearchOutOfNodes;
	public float PathfindingTime;
	public double PathCost;
	public int PathfindingSteps;
	public ANavigationTestingActor OtherActor;
	public UClass FilterClass;
	public int ShowStepIndex;
	public float OffsetFromCornersDistance;
}
