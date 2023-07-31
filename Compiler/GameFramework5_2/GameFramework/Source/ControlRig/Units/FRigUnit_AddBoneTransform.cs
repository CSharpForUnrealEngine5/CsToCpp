#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Offset Transform is used to perform a change in the hierarchy by setting a single bone&#39;s transform.</summary>
[CppInclude("Units/Hierarchy/RigUnit_AddBoneTransform.h")]
public partial struct FRigUnit_AddBoneTransform {
	public string Bone;
	public FTransform Transform;
	public float Weight;
	public bool bPostMultiply;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedBone;
}
