#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_Slot.h")]
///<summary>An animation slot node normally acts as a passthru, but a montage or PlaySlotAnimation call from</summary>
public partial struct FAnimNode_Slot {
// AnimNode_Slot
	public FPoseLink Source;
	public string SlotName;
	public bool bAlwaysUpdateSourcePose;
}
