#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetBoneRotation.h")]
///<summary>SetBoneRotation is used to perform a change in the hierarchy by setting a single bone's rotation.</summary>
public partial struct FRigUnit_SetBoneRotation {
// RigUnit_SetBoneRotation
	public string Bone;
	public FQuat Rotation;
	public ERigVMTransformSpace Space;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedBone;
}
