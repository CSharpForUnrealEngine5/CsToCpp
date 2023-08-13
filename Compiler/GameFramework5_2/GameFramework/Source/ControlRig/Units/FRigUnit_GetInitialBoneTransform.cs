namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GetInitialBoneTransform is used to retrieve a single transform from a hierarchy.</summary>
[CppInclude("Units/Hierarchy/RigUnit_GetInitialBoneTransform.h")]
public partial struct FRigUnit_GetInitialBoneTransform {
	public string Bone;
	public ERigVMTransformSpace Space;
	public FTransform Transform;
	public FCachedRigElement CachedBone;
}
