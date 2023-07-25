#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Async/AsyncAction_PerformTargeting.h")]
///<summary>@class UAsyncAction_PerformTargeting</summary>
public partial class UAsyncAction_PerformTargeting : UBlueprintAsyncActionBase {
// AsyncAction_PerformTargeting
	public UObject PerformTargetingRequest(UObject SourceActor,UObject TargetingPreset,bool bUseAsyncTargeting) { return default; }
	public UObject PerformFilteringRequest(UObject SourceActor,UObject TargetingPreset,bool bUseAsyncTargeting,TArray<UObject> InTargets) { return default; }
	public FPerformTargetingReady Targeted;
	public UTargetingPreset TargetingPreset;
	public TWeakObjectPtr<AActor> WeakSourceActor;
	public TArray<AActor> InitialTargets;
	public bool bUseAsyncTargeting;
}
