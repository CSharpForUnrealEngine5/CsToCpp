#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetBoneRotation is used to perform a change in the hierarchy by setting a single bone&#39;s rotation.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetBoneRotation.h")]
public partial struct FRigUnit_SetBoneRotation {
	public string Bone;
	public FQuat Rotation;
	public ERigVMTransformSpace Space;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedBone;
}
