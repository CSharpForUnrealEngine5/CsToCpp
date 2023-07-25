#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_AddBoneTransform.h")]
///<summary>Offset Transform is used to perform a change in the hierarchy by setting a single bone's transform.</summary>
public partial struct FRigUnit_AddBoneTransform {
// RigUnit_AddBoneTransform
	public string Bone;
	public FTransform Transform;
	public float Weight;
	public bool bPostMultiply;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedBone;
}
