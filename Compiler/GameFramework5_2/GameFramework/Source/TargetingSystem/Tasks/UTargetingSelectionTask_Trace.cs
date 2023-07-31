#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>@class UTargetingSelectionTask_Trace</summary>
[CppInclude("Tasks/TargetingSelectionTask_Trace.h")]
public partial class UTargetingSelectionTask_Trace : UTargetingTask {
	///<summary>Native Event to get the source location for the Trace</summary>
	public  FVector GetSourceLocation(FTargetingRequestHandle TargetingHandle) { return default; }
	///<summary>Native Event to get a source location offset for the Trace</summary>
	public  FVector GetSourceOffset(FTargetingRequestHandle TargetingHandle) { return default; }
	///<summary>Native Event to get the direction for the Trace</summary>
	public  FVector GetTraceDirection(FTargetingRequestHandle TargetingHandle) { return default; }
	///<summary>Native Event to get the length for the Trace</summary>
	public  float GetTraceLength(FTargetingRequestHandle TargetingHandle) { return default; }
	///<summary>Native Event to get the swept trace radius (only called if bSweptTrace is true)</summary>
	public  float GetSweptTraceRadius(FTargetingRequestHandle TargetingHandle) { return default; }
	///<summary>Native Event to get additional actors the Trace should ignore</summary>
	public  void GetAdditionalActorsToIgnore(FTargetingRequestHandle TargetingHandle,TArray<AActor> OutAdditionalActorsToIgnore) {}
	///<summary>The trace type to use</summary>
	public ETargetingTraceType TraceType;
	///<summary>The trace channel to use</summary>
	public ETraceTypeQuery TraceChannel;
	///<summary>The collision profile name to use instead of trace channel (does not work for async traces)</summary>
	public FCollisionProfileName CollisionProfileName;
	///<summary>The default swept trace radius used by GetSweptTraceRadius when the trace type is set to Sweep</summary>
	public FScalableFloat DefaultSweptTraceRadius;
	///<summary>The default trace length to use if GetTraceLength is not overridden by a child</summary>
	public FScalableFloat DefaultTraceLength;
	///<summary>The default source location offset used by GetSourceOffset</summary>
	public FVector DefaultSourceOffset;
	///<summary>An explicit trace direction to use (default uses pawn control rotation or actor forward vector in GetTraceDirection)</summary>
	public FVector ExplicitTraceDirection;
	///<summary>Indicates the trace should perform a complex trace</summary>
	public bool bComplexTrace;
	///<summary>Indicates the trace should ignore the source actor</summary>
	public bool bIgnoreSourceActor;
	///<summary>Indicates the trace should ignore the source actor</summary>
	public bool bIgnoreInstigatorActor;
}
