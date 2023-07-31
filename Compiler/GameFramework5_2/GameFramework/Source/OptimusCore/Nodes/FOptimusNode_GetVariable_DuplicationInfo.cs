#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information to hold data on the variable definition that persists over node duplication.</summary>
[CppInclude("Nodes/OptimusNode_GetVariable.h")]
public partial struct FOptimusNode_GetVariable_DuplicationInfo {
	public string VariableName;
	public FOptimusDataTypeRef DataType;
	public string DefaultValue;
}
