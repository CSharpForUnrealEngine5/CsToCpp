namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Switches an element to a new parent.</summary>
[CppInclude("Units/Execution/RigUnit_DynamicHierarchy.h")]
public partial struct FRigUnit_SwitchParent {
	public ERigSwitchParentMode Mode;
	public FRigElementKey Child;
	public FRigElementKey Parent;
	public bool bMaintainGlobal;
}
