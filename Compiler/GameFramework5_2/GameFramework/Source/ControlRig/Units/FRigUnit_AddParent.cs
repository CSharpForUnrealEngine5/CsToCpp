namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Adds a new parent to an element. The weight for the new parent will be 0.0.</summary>
[CppInclude("Units/Execution/RigUnit_DynamicHierarchy.h")]
public partial struct FRigUnit_AddParent {
	public FRigElementKey Child;
	public FRigElementKey Parent;
}
