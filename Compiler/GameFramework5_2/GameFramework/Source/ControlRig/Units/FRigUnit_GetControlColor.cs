namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GetControlColor is used to retrieve the color of control</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetControlColor.h")]
public partial struct FRigUnit_GetControlColor {
	public FName Control;
	public FLinearColor Color;
	public FCachedRigElement CachedControlIndex;
}
