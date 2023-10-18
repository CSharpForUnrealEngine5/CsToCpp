namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetControlVisibility is used to change the visibility on a control at runtime</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetControlVisibility.h")]
public partial struct FRigUnit_SetControlVisibility {
	public FRigElementKey Item;
	public string Pattern;
	public bool bVisible;
	public TArray<FCachedRigElement> CachedControlIndices;
}
