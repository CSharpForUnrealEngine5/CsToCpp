#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGizmoTransformChangeStateTarget is an implementation of IGizmoStateTarget that</summary>
[CppInclude("BaseGizmos/StateTargets.h")]
public partial class UGizmoTransformChangeStateTarget : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Pointer to the GizmoManager or ToolManager that is used to open/close the transaction</summary>
	public object /*TransactionManager*/ TransactionManager;
}
