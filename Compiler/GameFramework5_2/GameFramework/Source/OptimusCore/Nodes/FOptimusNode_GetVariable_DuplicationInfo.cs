#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/OptimusNode_GetVariable.h")]
///<summary>Information to hold data on the variable definition that persists over node duplication.</summary>
public partial struct FOptimusNode_GetVariable_DuplicationInfo {
// OptimusNode_GetVariable_DuplicationInfo
	public string VariableName;
	public FOptimusDataTypeRef DataType;
	public string DefaultValue;
}
