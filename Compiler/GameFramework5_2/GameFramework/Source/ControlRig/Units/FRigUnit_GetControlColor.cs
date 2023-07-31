#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GetControlColor is used to retrieve the color of control</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetControlColor.h")]
public partial struct FRigUnit_GetControlColor {
	public string Control;
	public FLinearColor Color;
	public FCachedRigElement CachedControlIndex;
}
