namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Changes the default parent for an item - this removes all other current parents.</summary>
[CppInclude("Units/Execution/RigUnit_DynamicHierarchy.h")]
public partial struct FRigUnit_SetDefaultParent {
	public FRigElementKey Child;
	public FRigElementKey Parent;
}
