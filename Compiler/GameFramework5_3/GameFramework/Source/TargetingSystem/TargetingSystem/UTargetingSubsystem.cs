namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>@class UTargetingSubsystem</summary>
[CppInclude("TargetingSystem/TargetingSubsystem.h")]
public partial class UTargetingSubsystem : UGameInstanceSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Method to execute an immediate targeting request based on a gameplay targeting preset.</summary>
	public void ExecuteTargetingRequest(UTargetingPreset TargetingPreset,FTargetingSourceContext InSourceContext,FTargetingRequestDynamicDelegate CompletionDynamicDelegate) {}
	///<summary>Method to remove an async targeting request with a given targeting handle</summary>
	public void RemoveAsyncTargetingRequestWithHandle(FTargetingRequestHandle TargetingHandle) {}
	///<summary>Method to queue an async targeting request based on a gameplay targeting preset.</summary>
	public FTargetingRequestHandle StartAsyncTargetingRequest(UTargetingPreset TargetingPreset,FTargetingSourceContext InSourceContext,FTargetingRequestDynamicDelegate CompletionDynamicDelegate) { return default; }
	///<summary>The set of target requests queued up for async processing</summary>
	public TArray<FTargetingRequestHandle> AsyncTargetingRequests;
	///<summary>Returns the targeting source context for the targeting request handle</summary>
	public FTargetingSourceContext GetTargetingSourceContext(FTargetingRequestHandle TargetingHandle) { return default; }
	///<summary>Method to get the actor targets from a given targeting request handle</summary>
	public void GetTargetingResultsActors(FTargetingRequestHandle TargetingHandle,TArray<AActor> Targets) {}
	///<summary>Helper method to get the set of hit results for a given targeting handle</summary>
	public void GetTargetingResults(FTargetingRequestHandle TargetingHandle,TArray<FHitResult> OutTargets) {}
	///<summary>Function that lets you set a data store from a certain Targeting Handle to add some Collision Query Param Overrides</summary>
	public static void OverrideCollisionQueryTaskData(FTargetingRequestHandle TargetingHandle,FCollisionQueryTaskData CollisionQueryDataOverride) {}
}
