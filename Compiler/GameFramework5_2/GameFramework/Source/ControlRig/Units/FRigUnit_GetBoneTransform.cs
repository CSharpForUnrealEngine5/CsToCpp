namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GetBoneTransform is used to retrieve a single transform from a hierarchy.</summary>
[CppInclude("Units/Hierarchy/RigUnit_GetBoneTransform.h")]
public partial struct FRigUnit_GetBoneTransform {
	public FName Bone;
	public ERigVMTransformSpace Space;
	public FTransform Transform;
	public FCachedRigElement CachedBone;
}
