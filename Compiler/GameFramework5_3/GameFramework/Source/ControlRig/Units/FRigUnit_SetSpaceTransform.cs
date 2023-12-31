namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetSpaceTransform is used to perform a change in the hierarchy by setting a single space&#39;s transform.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetSpaceTransform.h")]
public partial struct FRigUnit_SetSpaceTransform {
	public FName Space;
	public float Weight;
	public FTransform Transform;
	public ERigVMTransformSpace SpaceType;
	public FCachedRigElement CachedSpaceIndex;
}
