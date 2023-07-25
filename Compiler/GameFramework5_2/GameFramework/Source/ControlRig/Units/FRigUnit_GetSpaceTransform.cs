#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_GetSpaceTransform.h")]
///<summary>GetSpaceTransform is used to retrieve a single transform from a hierarchy.</summary>
public partial struct FRigUnit_GetSpaceTransform {
// RigUnit_GetSpaceTransform
	public string Space;
	public ERigVMTransformSpace SpaceType;
	public FTransform Transform;
	public FCachedRigElement CachedSpaceIndex;
}
