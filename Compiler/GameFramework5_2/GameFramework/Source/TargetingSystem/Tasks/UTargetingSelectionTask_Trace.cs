#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tasks/TargetingSelectionTask_Trace.h")]
///<summary>@class UTargetingSelectionTask_Trace</summary>
public partial class UTargetingSelectionTask_Trace : UTargetingTask {
// TargetingSelectionTask_Trace
	public FVector GetSourceLocation(FTargetingRequestHandle TargetingHandle) { return default; }
	public FVector GetSourceOffset(FTargetingRequestHandle TargetingHandle) { return default; }
	public FVector GetTraceDirection(FTargetingRequestHandle TargetingHandle) { return default; }
	public float GetTraceLength(FTargetingRequestHandle TargetingHandle) { return default; }
	public float GetSweptTraceRadius(FTargetingRequestHandle TargetingHandle) { return default; }
	public void GetAdditionalActorsToIgnore(FTargetingRequestHandle TargetingHandle,TArray<UObject> OutAdditionalActorsToIgnore) {}
	public ETargetingTraceType TraceType;
	public byte TraceChannel;
	public FCollisionProfileName CollisionProfileName;
	public FScalableFloat DefaultSweptTraceRadius;
	public FScalableFloat DefaultTraceLength;
	public FVector DefaultSourceOffset;
	public FVector ExplicitTraceDirection;
	public bool bComplexTrace;
	public bool bIgnoreSourceActor;
	public bool bIgnoreInstigatorActor;
}
