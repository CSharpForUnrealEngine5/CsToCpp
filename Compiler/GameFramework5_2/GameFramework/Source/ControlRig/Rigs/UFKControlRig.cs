namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Rig that allows override editing per joint</summary>
[CppInclude("Rigs/FKControlRig.h")]
public partial class UFKControlRig : UControlRig {
	public static UClass StaticClass() {return default;}
	///<summary>IsControlActive</summary>
	public TArray<bool> IsControlActive;
	///<summary>ApplyMode</summary>
	public EControlRigFKRigExecuteMode ApplyMode;
}
