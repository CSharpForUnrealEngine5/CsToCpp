#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_ObserveBone.h")]
///<summary>Debugging node that displays the current value of a bone in a specific space.</summary>
public partial struct FAnimNode_ObserveBone {
// AnimNode_ObserveBone
	public FBoneReference BoneToObserve;
	public EBoneControlSpace DisplaySpace;
	public bool bRelativeToRefPose;
	public FVector Translation;
	public FRotator Rotation;
	public FVector Scale;
}
