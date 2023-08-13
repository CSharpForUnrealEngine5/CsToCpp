namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GetControlVisibility is used to retrieve the visibility of a control</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetControlVisibility.h")]
public partial struct FRigUnit_GetControlVisibility {
	public FRigElementKey Item;
	public bool bVisible;
	public FCachedRigElement CachedControlIndex;
}
