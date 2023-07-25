#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_DynamicHierarchy.h")]
///<summary>Adds a new parent to an element. The weight for the new parent will be 0.0.</summary>
public partial struct FRigUnit_AddParent {
// RigUnit_AddParent
	public FRigElementKey Child;
	public FRigElementKey Parent;
}
