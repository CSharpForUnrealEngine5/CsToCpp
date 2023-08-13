namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetRelativeBoneTransform is used to perform a change in the hierarchy by setting a single bone&#39;s transform.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetRelativeBoneTransform.h")]
public partial struct FRigUnit_SetRelativeBoneTransform {
	public string Bone;
	public string Space;
	public FTransform Transform;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedBone;
	public FCachedRigElement CachedSpaceIndex;
}
