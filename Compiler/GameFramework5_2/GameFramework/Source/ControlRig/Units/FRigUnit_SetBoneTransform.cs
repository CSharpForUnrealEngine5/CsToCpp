namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetBoneTransform is used to perform a change in the hierarchy by setting a single bone&#39;s transform.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetBoneTransform.h")]
public partial struct FRigUnit_SetBoneTransform {
	public FName Bone;
	public FTransform Transform;
	public FTransform Result;
	public ERigVMTransformSpace Space;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedBone;
}
