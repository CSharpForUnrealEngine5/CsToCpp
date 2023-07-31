#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GetBoneTransform is used to retrieve a single transform from a hierarchy.</summary>
[CppInclude("Units/Hierarchy/RigUnit_GetBoneTransform.h")]
public partial struct FRigUnit_GetBoneTransform {
	public string Bone;
	public ERigVMTransformSpace Space;
	public FTransform Transform;
	public FCachedRigElement CachedBone;
}
