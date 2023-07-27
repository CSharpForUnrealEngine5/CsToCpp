#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AISystem.h")]
public partial class UAISystem : UAISystemBase {
// AISystem
	public FSoftClassPath PerceptionSystemClassName;
	public FSoftClassPath HotSpotManagerClassName;
	public FSoftClassPath EnvQueryManagerClassName;
	public float AcceptanceRadius;
	public float PathfollowingRegularPathPointAcceptanceRadius;
	public float PathfollowingNavLinkAcceptanceRadius;
	public bool bFinishMoveOnGoalOverlap;
	public bool bAcceptPartialPaths;
	public bool bAllowStrafing;
	public bool bAllowControllersAsEQSQuerier;
	public bool bEnableDebuggerPlugin;
	public bool bForgetStaleActors;
	public bool bAddBlackboardSelfKey;
	public bool bClearBBEntryOnBTEQSFail;
	public bool bBlackboardKeyDecoratorAllowsNoneAsValue;
	public ECollisionChannel DefaultSightCollisionChannel;
	public UBehaviorTreeManager BehaviorTreeManager;
	public UEnvQueryManager EnvironmentQueryManager;
	public UAIPerceptionSystem PerceptionSystem;
	public TArray<UAIAsyncTaskBlueprintProxy> AllProxyObjects;
	public UAIHotSpotManager HotSpotManager;
	public UNavLocalGridManager NavLocalGrids;
	public  void AIIgnorePlayers() {}
	public  void AILoggingVerbose() {}
}
