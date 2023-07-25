#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/FKControlRig.h")]
///<summary>Rig that allows override editing per joint</summary>
public partial class UFKControlRig : UControlRig {
// FKControlRig
	public TArray<bool> IsControlActive;
	public EControlRigFKRigExecuteMode ApplyMode;
}
