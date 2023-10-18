namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGizmoObjectModifyStateTarget is an implementation of IGizmoStateTarget that</summary>
[CppInclude("BaseGizmos/StateTargets.h")]
public partial class UGizmoObjectModifyStateTarget : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Pointer to the GizmoManager or ToolManager that is used to open/close the transaction</summary>
	public object /*TransactionManager*/ TransactionManager;
}
