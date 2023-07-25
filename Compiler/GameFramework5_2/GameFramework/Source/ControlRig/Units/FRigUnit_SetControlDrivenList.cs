#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetControlDrivenList.h")]
///<summary>SetControlDrivenList is used to change the list of affected controls of an indirect control</summary>
public partial struct FRigUnit_SetControlDrivenList {
// RigUnit_SetControlDrivenList
	public string Control;
	public TArray<FRigElementKey> Driven;
	public FCachedRigElement CachedControlIndex;
}
