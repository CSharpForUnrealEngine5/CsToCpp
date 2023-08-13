namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetBoneTranslation is used to perform a change in the hierarchy by setting a single bone&#39;s Translation.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetBoneTranslation.h")]
public partial struct FRigUnit_SetBoneTranslation {
	public string Bone;
	public FVector Translation;
	public ERigVMTransformSpace Space;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedBone;
}
