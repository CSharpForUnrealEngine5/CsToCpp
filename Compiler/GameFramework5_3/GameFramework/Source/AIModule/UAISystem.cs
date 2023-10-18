namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AISystem.h")]
public partial class UAISystem : UAISystemBase {
	public static UClass StaticClass() {return default;}
	///<summary>Class that will be used to spawn the perception system, can be game-specific</summary>
	public FSoftClassPath PerceptionSystemClassName;
	///<summary>Class that will be used to spawn the hot spot manager, can be game-specific</summary>
	public FSoftClassPath HotSpotManagerClassName;
	///<summary>Class that will be used to spawn the env query manager, can be game-specific</summary>
	public FSoftClassPath EnvQueryManagerClassName;
	///<summary>Default AI movement&#39;s acceptance radius used to determine whether</summary>
	public float AcceptanceRadius;
	///<summary>Value used for pathfollowing&#39;s internal code to determine whether AI reached path&#39;s point.</summary>
	public float PathfollowingRegularPathPointAcceptanceRadius;
	///<summary>Similarly to PathfollowingRegularPathPointAcceptanceRadius used by pathfollowing&#39;s internals</summary>
	public float PathfollowingNavLinkAcceptanceRadius;
	///<summary>If true, overlapping the goal will be counted by default as finishing a move</summary>
	public bool bFinishMoveOnGoalOverlap;
	///<summary>Sets default value for rather move tasks accept partial paths or not</summary>
	public bool bAcceptPartialPaths;
	///<summary>Sets default value for rather move tasks allow strafing or not</summary>
	public bool bAllowStrafing;
	///<summary>if enable will make EQS not complaint about using Controllers as queriers. Default behavior (false) will</summary>
	public bool bAllowControllersAsEQSQuerier;
	///<summary>if set, GameplayDebuggerPlugin will be loaded on module&#39;s startup</summary>
	public bool bEnableDebuggerPlugin;
	///<summary>If set, actors will be forgotten by the perception system when their stimulus has expired.</summary>
	public bool bForgetStaleActors;
	///<summary>If set to true will result in automatically adding the SelfActor key to new Blackboard assets. It will</summary>
	public bool bAddBlackboardSelfKey;
	///<summary>bClearBBEntryOnBTEQSFail</summary>
	public bool bClearBBEntryOnBTEQSFail;
	///<summary>If enabled, blackboard based decorators will set key to &#39;Invalid&#39; on creation or when selected key no longer exists (instead of using the first key of the blackboard).</summary>
	public bool bBlackboardKeyDecoratorAllowsNoneAsValue;
	///<summary>If set, new BTs will use this BB as default.</summary>
	public TSoftObjectPtr<UBlackboardData> DefaultBlackboard;
	///<summary>Which collision channel to use for sight checks by default</summary>
	public ECollisionChannel DefaultSightCollisionChannel;
	///<summary>Behavior tree manager used by game</summary>
	public UBehaviorTreeManager BehaviorTreeManager;
	///<summary>Environment query manager used by game</summary>
	public UEnvQueryManager EnvironmentQueryManager;
	///<summary>PerceptionSystem</summary>
	public UAIPerceptionSystem PerceptionSystem;
	///<summary>AllProxyObjects</summary>
	public TArray<UAIAsyncTaskBlueprintProxy> AllProxyObjects;
	///<summary>HotSpotManager</summary>
	public UAIHotSpotManager HotSpotManager;
	///<summary>NavLocalGrids</summary>
	public UNavLocalGridManager NavLocalGrids;
	///<summary>cheats</summary>
	public virtual void AIIgnorePlayers() {}
	///<summary>AILoggingVerbose</summary>
	public virtual void AILoggingVerbose() {}
}
