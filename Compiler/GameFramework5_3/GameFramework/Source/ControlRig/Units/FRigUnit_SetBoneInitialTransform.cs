namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetBoneInitialTransform is used to perform a change in the hierarchy by setting a single bone&#39;s transform.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetBoneInitialTransform.h")]
public partial struct FRigUnit_SetBoneInitialTransform {
	public FName Bone;
	public FTransform Transform;
	public FTransform Result;
	public ERigVMTransformSpace Space;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedBone;
}
