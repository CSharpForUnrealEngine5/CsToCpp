#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetControlVisibility.h")]
///<summary>SetControlVisibility is used to change the visibility on a control at runtime</summary>
public partial struct FRigUnit_SetControlVisibility {
// RigUnit_SetControlVisibility
	public FRigElementKey Item;
	public string Pattern;
	public bool bVisible;
	public TArray<FCachedRigElement> CachedControlIndices;
}
