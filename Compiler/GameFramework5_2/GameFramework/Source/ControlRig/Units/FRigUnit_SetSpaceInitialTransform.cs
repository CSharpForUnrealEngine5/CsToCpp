#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetSpaceInitialTransform is used to perform a change in the hierarchy by setting a single space&#39;s initial transform.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetSpaceInitialTransform.h")]
public partial struct FRigUnit_SetSpaceInitialTransform {
	public string SpaceName;
	public FTransform Transform;
	public FTransform Result;
	public ERigVMTransformSpace Space;
	public FCachedRigElement CachedSpaceIndex;
}
