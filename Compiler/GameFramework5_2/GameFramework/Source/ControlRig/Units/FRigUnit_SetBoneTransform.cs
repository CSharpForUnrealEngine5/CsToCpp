#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetBoneTransform.h")]
///<summary>SetBoneTransform is used to perform a change in the hierarchy by setting a single bone's transform.</summary>
public partial struct FRigUnit_SetBoneTransform {
// RigUnit_SetBoneTransform
	public string Bone;
	public FTransform Transform;
	public FTransform Result;
	public ERigVMTransformSpace Space;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedBone;
}
