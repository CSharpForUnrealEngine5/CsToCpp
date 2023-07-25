#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_GetRelativeBoneTransform.h")]
///<summary>GetBoneTransform is used to retrieve a single transform from a hierarchy.</summary>
public partial struct FRigUnit_GetRelativeBoneTransform {
// RigUnit_GetRelativeBoneTransform
	public string Bone;
	public string Space;
	public FTransform Transform;
	public FCachedRigElement CachedBone;
	public FCachedRigElement CachedSpace;
}
