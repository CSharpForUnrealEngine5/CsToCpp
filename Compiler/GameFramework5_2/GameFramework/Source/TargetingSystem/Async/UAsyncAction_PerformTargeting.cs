#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>@class UAsyncAction_PerformTargeting</summary>
[CppInclude("Async/AsyncAction_PerformTargeting.h")]
public partial class UAsyncAction_PerformTargeting : UBlueprintAsyncActionBase {
	///<summary>PerformTargetingRequest</summary>
	public static UAsyncAction_PerformTargeting PerformTargetingRequest(AActor SourceActor,UTargetingPreset TargetingPreset,bool bUseAsyncTargeting) { return default; }
	///<summary>PerformFilteringRequest</summary>
	public static UAsyncAction_PerformTargeting PerformFilteringRequest(AActor SourceActor,UTargetingPreset TargetingPreset,bool bUseAsyncTargeting,TArray<AActor> InTargets) { return default; }
	///<summary>Targeted</summary>
	public FPerformTargetingReady Targeted;
	///<summary>The targeting preset to use for targeting</summary>
	public UTargetingPreset TargetingPreset;
	///<summary>The actor this task is running for</summary>
	public TWeakObjectPtr<AActor> WeakSourceActor;
	///<summary>A set of targets to pre-seed the targeting request with (great for filtering targets without the needs for selection)</summary>
	public TArray<AActor> InitialTargets;
	///<summary>Flag to indicate we should be using async targeting (default is immediate execution)</summary>
	public bool bUseAsyncTargeting;
}
