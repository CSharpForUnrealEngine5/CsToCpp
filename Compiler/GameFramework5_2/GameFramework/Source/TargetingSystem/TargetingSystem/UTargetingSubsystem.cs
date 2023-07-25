#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TargetingSystem/TargetingSubsystem.h")]
///<summary>@class UTargetingSubsystem</summary>
public partial class UTargetingSubsystem : UGameInstanceSubsystem {
// TargetingSubsystem
	public void ExecuteTargetingRequest(UObject TargetingPreset,FTargetingSourceContext InSourceContext,FTargetingRequestDynamicDelegate CompletionDynamicDelegate) {}
	public void RemoveAsyncTargetingRequestWithHandle(FTargetingRequestHandle TargetingHandle) {}
	public FTargetingRequestHandle StartAsyncTargetingRequest(UObject TargetingPreset,FTargetingSourceContext InSourceContext,FTargetingRequestDynamicDelegate CompletionDynamicDelegate) { return default; }
	public TArray<FTargetingRequestHandle> AsyncTargetingRequests;
	public FTargetingSourceContext GetTargetingSourceContext(FTargetingRequestHandle TargetingHandle) { return default; }
	public void GetTargetingResultsActors(FTargetingRequestHandle TargetingHandle,TArray<UObject> Targets) {}
	public void GetTargetingResults(FTargetingRequestHandle TargetingHandle,TArray<FHitResult> OutTargets) {}
}
