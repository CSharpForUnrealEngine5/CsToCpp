#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetSpaceInitialTransform.h")]
///<summary>SetSpaceInitialTransform is used to perform a change in the hierarchy by setting a single space's initial transform.</summary>
public partial struct FRigUnit_SetSpaceInitialTransform {
// RigUnit_SetSpaceInitialTransform
	public string SpaceName;
	public FTransform Transform;
	public FTransform Result;
	public ERigVMTransformSpace Space;
	public FCachedRigElement CachedSpaceIndex;
}
