namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Metadata/PCGMetadataBitwiseOpElement.h")]
public partial class UPCGMetadataBitwiseSettings : UPCGMetadataSettingsBase {
	public static UClass StaticClass() {return default;}
	///<summary>Operation</summary>
	public EPCGMedadataBitwiseOperation Operation;
	///<summary>InputSource1</summary>
	public FPCGAttributePropertySelector InputSource1;
	///<summary>InputSource2</summary>
	public FPCGAttributePropertySelector InputSource2;
	///<summary>Input1AttributeName_DEPRECATED</summary>
	public string Input1AttributeName_DEPRECATED;
	///<summary>Input2AttributeName_DEPRECATED</summary>
	public string Input2AttributeName_DEPRECATED;
}
