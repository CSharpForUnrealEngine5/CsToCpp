namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeEnumParameter.h")]
public partial class UCustomizableObjectNodeEnumParameter : UCustomizableObjectNode {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultIndex</summary>
	public int DefaultIndex;
	///<summary>ParameterName</summary>
	public string ParameterName;
	///<summary>ParamUIMetadata</summary>
	public FMutableParamUIMetadata ParamUIMetadata;
	///<summary>Values</summary>
	public TArray<FCustomizableObjectNodeEnumValue> Values;
}
