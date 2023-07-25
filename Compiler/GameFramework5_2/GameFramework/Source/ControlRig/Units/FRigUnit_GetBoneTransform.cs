#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_GetBoneTransform.h")]
///<summary>GetBoneTransform is used to retrieve a single transform from a hierarchy.</summary>
public partial struct FRigUnit_GetBoneTransform {
// RigUnit_GetBoneTransform
	public string Bone;
	public ERigVMTransformSpace Space;
	public FTransform Transform;
	public FCachedRigElement CachedBone;
}
