#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Metadata/PCGMetadataTrigOpElement.h")]
public partial class UPCGMetadataTrigSettings : UPCGMetadataSettingsBase {
	///<summary>Operation</summary>
	public EPCGMedadataTrigOperation Operation;
	///<summary>InputSource1</summary>
	public FPCGAttributePropertySelector InputSource1;
	///<summary>InputSource2</summary>
	public FPCGAttributePropertySelector InputSource2;
	///<summary>Input1AttributeName_DEPRECATED</summary>
	public string Input1AttributeName_DEPRECATED;
	///<summary>Input2AttributeName_DEPRECATED</summary>
	public string Input2AttributeName_DEPRECATED;
}
