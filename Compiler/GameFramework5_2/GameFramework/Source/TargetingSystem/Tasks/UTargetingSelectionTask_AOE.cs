namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>@class UTargetingSelectionTask_AOE</summary>
[CppInclude("Tasks/TargetingSelectionTask_AOE.h")]
public partial class UTargetingSelectionTask_AOE : UTargetingTask {
	public static UClass StaticClass() {return default;}
	///<summary>Native Event to get the source location for the AOE</summary>
	public FVector GetSourceLocation(FTargetingRequestHandle TargetingHandle) { return default; }
	///<summary>Native Event to get a source location offset for the AOE</summary>
	public FVector GetSourceOffset(FTargetingRequestHandle TargetingHandle) { return default; }
	///<summary>The shape type to use for the AOE</summary>
	public ETargetingAOEShape ShapeType;
	///<summary>The collision channel to use for the overlap check (as long as Collision Profile Name is not set)</summary>
	public ECollisionChannel CollisionChannel;
	///<summary>The collision profile name to use for the overlap check</summary>
	public FCollisionProfileName CollisionProfileName;
	///<summary>The collision profile name to use for the overlap check</summary>
	public TArray<EObjectTypeQuery> CollisionObjectTypes;
	///<summary>The default source location offset used by GetSourceOffset</summary>
	public FVector DefaultSourceOffset;
	///<summary>Indicates the trace should ignore the source actor</summary>
	public bool bIgnoreSourceActor;
	///<summary>Indicates the trace should ignore the source actor</summary>
	public bool bIgnoreInstigatorActor;
	///<summary>The half extent to use for box and cylinder</summary>
	public FVector HalfExtent;
	///<summary>The radius to use for sphere and capsule overlaps</summary>
	public FScalableFloat Radius;
	///<summary>The half height to use for capsule overlap checks</summary>
	public FScalableFloat HalfHeight;
	///<summary>The component tag to use if a custom component is desired as the overlap shape.</summary>
	public string ComponentTag;
}
