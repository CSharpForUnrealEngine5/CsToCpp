#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/OptimusNode_GetVariable.h")]
public partial class UOptimusNode_GetVariable : UOptimusNode {
	///<summary>VariableDesc</summary>
	public TWeakObjectPtr<UOptimusVariableDescription> VariableDesc;
	///<summary>Duplication data across graphs</summary>
	public FOptimusNode_GetVariable_DuplicationInfo DuplicationInfo;
}
