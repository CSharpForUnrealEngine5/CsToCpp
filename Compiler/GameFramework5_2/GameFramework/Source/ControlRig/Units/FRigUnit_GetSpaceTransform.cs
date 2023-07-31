#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GetSpaceTransform is used to retrieve a single transform from a hierarchy.</summary>
[CppInclude("Units/Hierarchy/RigUnit_GetSpaceTransform.h")]
public partial struct FRigUnit_GetSpaceTransform {
	public string Space;
	public ERigVMTransformSpace SpaceType;
	public FTransform Transform;
	public FCachedRigElement CachedSpaceIndex;
}
