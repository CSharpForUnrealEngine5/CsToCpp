#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusVariableDescription.h")]
public partial class UOptimusVariableDescription : UObject {
// OptimusVariableDescription
	public FGuid Guid;
	public string VariableName;
	public FOptimusDataTypeRef DataType;
	public UOptimusValueContainer DefaultValue;
	public TArray<byte> ValueData;
}
