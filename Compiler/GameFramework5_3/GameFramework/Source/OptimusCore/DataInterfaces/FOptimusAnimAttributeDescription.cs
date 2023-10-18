namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterfaces/OptimusDataInterfaceAnimAttribute.h")]
public partial struct FOptimusAnimAttributeDescription {
	public string Name;
	public FName BoneName;
	public FOptimusDataTypeRef DataType;
	public UOptimusValueContainer DefaultValue;
	public string HlslId;
	public FName PinName;
}
