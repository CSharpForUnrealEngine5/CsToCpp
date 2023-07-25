#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_DynamicHierarchy.h")]
///<summary>Changes the default parent for an item - this removes all other current parents.</summary>
public partial struct FRigUnit_SetDefaultParent {
// RigUnit_SetDefaultParent
	public FRigElementKey Child;
	public FRigElementKey Parent;
}
