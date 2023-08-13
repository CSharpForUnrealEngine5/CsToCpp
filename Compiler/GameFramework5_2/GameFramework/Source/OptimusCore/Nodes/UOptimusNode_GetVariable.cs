namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/OptimusNode_GetVariable.h")]
public partial class UOptimusNode_GetVariable : UOptimusNode {
	public static UClass StaticClass() {return default;}
	///<summary>VariableDesc</summary>
	public TWeakObjectPtr<UOptimusVariableDescription> VariableDesc;
	///<summary>Duplication data across graphs</summary>
	public FOptimusNode_GetVariable_DuplicationInfo DuplicationInfo;
}
