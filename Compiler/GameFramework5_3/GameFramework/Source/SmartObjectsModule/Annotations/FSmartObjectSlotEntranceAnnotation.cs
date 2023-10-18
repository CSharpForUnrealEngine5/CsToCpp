namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Annotation to define a entrance locations for a Smart Object Slot.</summary>
[CppInclude("Annotations/SmartObjectSlotEntranceAnnotation.h")]
public partial struct FSmartObjectSlotEntranceAnnotation {
	public FVector3f Offset;
	public FRotator3f Rotation;
	public FGameplayTag Tag_DEPRECATED;
	public FGameplayTagContainer Tags;
	public bool bIsEntry;
	public bool bIsExit;
	public bool bTraceGroundLocation;
	public bool bCheckTransitionTrajectory;
	public ESmartObjectEntrancePriority SelectionPriority;
	public float TrajectoryStartHeightOffset;
	public float TrajectorySlotHeightOffset;
	public float TransitionCheckRadius;
}
