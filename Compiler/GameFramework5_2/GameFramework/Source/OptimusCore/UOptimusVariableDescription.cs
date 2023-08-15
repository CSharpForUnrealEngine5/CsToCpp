namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusVariableDescription.h")]
public partial class UOptimusVariableDescription : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>An identifier that uniquely identifies this variable</summary>
	public FGuid Guid;
	///<summary>Name of the variable</summary>
	public FName VariableName;
	///<summary>The data type of the variable</summary>
	public FOptimusDataTypeRef DataType;
	///<summary>The default value for the variable.</summary>
	public UOptimusValueContainer DefaultValue;
	///<summary>Cached shader value binary data.</summary>
	public TArray<byte> ValueData;
}
