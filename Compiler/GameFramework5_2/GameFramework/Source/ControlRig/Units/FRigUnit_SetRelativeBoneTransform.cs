#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetRelativeBoneTransform.h")]
///<summary>SetRelativeBoneTransform is used to perform a change in the hierarchy by setting a single bone's transform.</summary>
public partial struct FRigUnit_SetRelativeBoneTransform {
// RigUnit_SetRelativeBoneTransform
	public string Bone;
	public string Space;
	public FTransform Transform;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedBone;
	public FCachedRigElement CachedSpaceIndex;
}
