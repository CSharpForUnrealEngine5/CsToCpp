#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BTDecorator.h")]
///<summary>Decorators are supporting nodes placed on parent-child connection, that receive notification about execution flow and can be ticked</summary>
public partial class UBTDecorator : UBTAuxiliaryNode {
// BTDecorator
	public bool bInverseCondition;
	public EBTFlowAbortMode FlowAbortMode;
}
