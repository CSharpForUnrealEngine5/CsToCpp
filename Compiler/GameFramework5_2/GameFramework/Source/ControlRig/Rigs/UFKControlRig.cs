#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Rig that allows override editing per joint</summary>
[CppInclude("Rigs/FKControlRig.h")]
public partial class UFKControlRig : UControlRig {
	///<summary>IsControlActive</summary>
	public TArray<bool> IsControlActive;
	///<summary>ApplyMode</summary>
	public EControlRigFKRigExecuteMode ApplyMode;
}
