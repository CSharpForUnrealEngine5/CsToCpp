namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTree/StateTreeTask_PlayContextualAnim.h")]
public partial class UStateTreeTask_PlayContextualAnim_InstanceData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>PrimaryActor</summary>
	public AActor PrimaryActor;
	///<summary>SecondaryActor</summary>
	public AActor SecondaryActor;
	///<summary>SecondaryRole</summary>
	public FName SecondaryRole;
	///<summary>TertiaryActor</summary>
	public AActor TertiaryActor;
	///<summary>TertiaryRole</summary>
	public FName TertiaryRole;
	///<summary>SceneAsset</summary>
	public UContextualAnimSceneAsset SceneAsset;
	///<summary>SectionName</summary>
	public FName SectionName;
	///<summary>ExecutionMethod</summary>
	public EPlayContextualAnimExecutionMethod ExecutionMethod;
	///<summary>There are cases where we may be &#39;chaining&#39; multiple interactions animations through different state tree tasks (e.g start -&gt; loop -&gt; end)</summary>
	public bool bWaitForNotifyEventToEnd;
	///<summary>When bWaitForNotifyEventToEnd is set to true this is the name of the notify that we will look for to signal the end of the task</summary>
	public FName NotifyEventNameToEnd;
	///<summary>How many times the animation should be run before completing the task.</summary>
	public int LoopsToRun;
	///<summary>If true the animation will loop forever until a transition stops it.</summary>
	public bool bLoopForever;
	///<summary>How many seconds should we wait between each animation loop (won&#39;t be used if RunLoops is equal 1).</summary>
	public float DelayBetweenLoops;
	///<summary>Adds random range to the DelayBetweenLoops.</summary>
	public float RandomDeviationBetweenLoops;
	///<summary>Manual warp targets for specific roles.</summary>
	public TArray<FContextualAnimWarpTarget> WarpTargets;
	///<summary>OnMontageEnded</summary>
	public void OnMontageEnded(UAnimMontage EndedMontage,bool bInterrupted) {}
	///<summary>OnNotifyBeginReceived</summary>
	public void OnNotifyBeginReceived(FName NotifyName,FBranchingPointNotifyPayload BranchingPointNotifyPayload) {}
}
