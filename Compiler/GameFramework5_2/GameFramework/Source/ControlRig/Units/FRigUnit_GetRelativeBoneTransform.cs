namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GetBoneTransform is used to retrieve a single transform from a hierarchy.</summary>
[CppInclude("Units/Hierarchy/RigUnit_GetRelativeBoneTransform.h")]
public partial struct FRigUnit_GetRelativeBoneTransform {
	public FName Bone;
	public FName Space;
	public FTransform Transform;
	public FCachedRigElement CachedBone;
	public FCachedRigElement CachedSpace;
}
