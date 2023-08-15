namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An animation slot node normally acts as a passthru, but a montage or PlaySlotAnimation call from</summary>
[CppInclude("AnimNodes/AnimNode_Slot.h")]
public partial struct FAnimNode_Slot {
	public FPoseLink Source;
	public FName SlotName;
	public bool bAlwaysUpdateSourcePose;
}
