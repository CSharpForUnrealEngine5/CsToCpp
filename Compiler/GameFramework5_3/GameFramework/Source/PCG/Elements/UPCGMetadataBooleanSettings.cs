namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Metadata/PCGMetadataBooleanOpElement.h")]
public partial class UPCGMetadataBooleanSettings : UPCGMetadataSettingsBase {
	public static UClass StaticClass() {return default;}
	///<summary>Operation</summary>
	public EPCGMedadataBooleanOperation Operation;
	///<summary>InputSource1</summary>
	public FPCGAttributePropertyInputSelector InputSource1;
	///<summary>InputSource2</summary>
	public FPCGAttributePropertyInputSelector InputSource2;
	///<summary>Input1AttributeName_DEPRECATED</summary>
	public FName Input1AttributeName_DEPRECATED;
	///<summary>Input2AttributeName_DEPRECATED</summary>
	public FName Input2AttributeName_DEPRECATED;
}
