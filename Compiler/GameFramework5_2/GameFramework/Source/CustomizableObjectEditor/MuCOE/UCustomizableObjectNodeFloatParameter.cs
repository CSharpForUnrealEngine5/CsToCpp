namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeFloatParameter.h")]
public partial class UCustomizableObjectNodeFloatParameter : UCustomizableObjectNode {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultValue</summary>
	public float DefaultValue;
	///<summary>ParameterName</summary>
	public string ParameterName;
	///<summary>ParamUIMetadata</summary>
	public FMutableParamUIMetadata ParamUIMetadata;
	///<summary>DescriptionImagePinsReferences</summary>
	public TArray<FEdGraphPinReference> DescriptionImagePinsReferences;
	///<summary>DescriptionImage</summary>
	public TArray<FCustomizableObjectNodeFloatDescription> DescriptionImage;
}
