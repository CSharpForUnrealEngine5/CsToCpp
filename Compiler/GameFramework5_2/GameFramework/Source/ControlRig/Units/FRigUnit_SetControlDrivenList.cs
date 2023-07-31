#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetControlDrivenList is used to change the list of affected controls of an indirect control</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetControlDrivenList.h")]
public partial struct FRigUnit_SetControlDrivenList {
	public string Control;
	public TArray<FRigElementKey> Driven;
	public FCachedRigElement CachedControlIndex;
}
