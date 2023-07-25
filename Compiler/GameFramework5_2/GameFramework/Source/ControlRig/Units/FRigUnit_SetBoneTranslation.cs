#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetBoneTranslation.h")]
///<summary>SetBoneTranslation is used to perform a change in the hierarchy by setting a single bone's Translation.</summary>
public partial struct FRigUnit_SetBoneTranslation {
// RigUnit_SetBoneTranslation
	public string Bone;
	public FVector Translation;
	public ERigVMTransformSpace Space;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedBone;
}
