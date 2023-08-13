namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Debugging node that displays the current value of a bone in a specific space.</summary>
[CppInclude("BoneControllers/AnimNode_ObserveBone.h")]
public partial struct FAnimNode_ObserveBone {
	public FBoneReference BoneToObserve;
	public EBoneControlSpace DisplaySpace;
	public bool bRelativeToRefPose;
	public FVector Translation;
	public FRotator Rotation;
	public FVector Scale;
}
