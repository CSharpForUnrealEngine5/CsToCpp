#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tasks/TargetingSelectionTask_AOE.h")]
///<summary>@class UTargetingSelectionTask_AOE</summary>
public partial class UTargetingSelectionTask_AOE : UTargetingTask {
// TargetingSelectionTask_AOE
	public  FVector GetSourceLocation(FTargetingRequestHandle TargetingHandle) { return default; }
	public  FVector GetSourceOffset(FTargetingRequestHandle TargetingHandle) { return default; }
	public ETargetingAOEShape ShapeType;
	public byte CollisionChannel;
	public FCollisionProfileName CollisionProfileName;
	public TArray<byte> CollisionObjectTypes;
	public FVector DefaultSourceOffset;
	public bool bIgnoreSourceActor;
	public bool bIgnoreInstigatorActor;
	public FVector HalfExtent;
	public FScalableFloat Radius;
	public FScalableFloat HalfHeight;
	public string ComponentTag;
}
