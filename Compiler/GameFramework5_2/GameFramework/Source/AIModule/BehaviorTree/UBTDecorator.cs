#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Decorators are supporting nodes placed on parent-child connection, that receive notification about execution flow and can be ticked</summary>
[CppInclude("BehaviorTree/BTDecorator.h")]
public partial class UBTDecorator : UBTAuxiliaryNode {
	///<summary>if set, condition check result will be inversed</summary>
	public bool bInverseCondition;
	///<summary>flow controller settings</summary>
	public EBTFlowAbortMode FlowAbortMode;
}
