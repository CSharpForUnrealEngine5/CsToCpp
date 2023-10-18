namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Metadata/PCGMetadataMathsOpElement.h")]
public partial class UPCGMetadataMathsSettings : UPCGMetadataSettingsBase {
	public static UClass StaticClass() {return default;}
	///<summary>Operation</summary>
	public EPCGMedadataMathsOperation Operation;
	///<summary>InputSource1</summary>
	public FPCGAttributePropertyInputSelector InputSource1;
	///<summary>InputSource2</summary>
	public FPCGAttributePropertyInputSelector InputSource2;
	///<summary>InputSource3</summary>
	public FPCGAttributePropertyInputSelector InputSource3;
	///<summary>Input1AttributeName_DEPRECATED</summary>
	public FName Input1AttributeName_DEPRECATED;
	///<summary>Input2AttributeName_DEPRECATED</summary>
	public FName Input2AttributeName_DEPRECATED;
	///<summary>Input3AttributeName_DEPRECATED</summary>
	public FName Input3AttributeName_DEPRECATED;
}
