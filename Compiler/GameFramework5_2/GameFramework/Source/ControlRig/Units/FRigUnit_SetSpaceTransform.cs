#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetSpaceTransform.h")]
///<summary>SetSpaceTransform is used to perform a change in the hierarchy by setting a single space's transform.</summary>
public partial struct FRigUnit_SetSpaceTransform {
// RigUnit_SetSpaceTransform
	public string Space;
	public float Weight;
	public FTransform Transform;
	public ERigVMTransformSpace SpaceType;
	public FCachedRigElement CachedSpaceIndex;
}
