#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_DynamicHierarchy.h")]
///<summary>Switches an element to a new parent.</summary>
public partial struct FRigUnit_SwitchParent {
// RigUnit_SwitchParent
	public ERigSwitchParentMode Mode;
	public FRigElementKey Child;
	public FRigElementKey Parent;
	public bool bMaintainGlobal;
}
