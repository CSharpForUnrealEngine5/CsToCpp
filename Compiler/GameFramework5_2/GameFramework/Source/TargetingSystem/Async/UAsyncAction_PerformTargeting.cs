#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Async/AsyncAction_PerformTargeting.h")]
///<summary>@class UAsyncAction_PerformTargeting</summary>
public partial class UAsyncAction_PerformTargeting : UBlueprintAsyncActionBase {
// AsyncAction_PerformTargeting
	public static UAsyncAction_PerformTargeting PerformTargetingRequest(AActor SourceActor,UTargetingPreset TargetingPreset,bool bUseAsyncTargeting) { return default; }
	public static UAsyncAction_PerformTargeting PerformFilteringRequest(AActor SourceActor,UTargetingPreset TargetingPreset,bool bUseAsyncTargeting,TArray<AActor> InTargets) { return default; }
	public FPerformTargetingReady Targeted;
	public UTargetingPreset TargetingPreset;
	public TWeakObjectPtr<AActor> WeakSourceActor;
	public TArray<AActor> InitialTargets;
	public bool bUseAsyncTargeting;
}
