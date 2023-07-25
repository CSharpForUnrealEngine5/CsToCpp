#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_GetInitialBoneTransform.h")]
///<summary>GetInitialBoneTransform is used to retrieve a single transform from a hierarchy.</summary>
public partial struct FRigUnit_GetInitialBoneTransform {
// RigUnit_GetInitialBoneTransform
	public string Bone;
	public ERigVMTransformSpace Space;
	public FTransform Transform;
	public FCachedRigElement CachedBone;
}
