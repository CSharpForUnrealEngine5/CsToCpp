#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Metadata/PCGMetadataBitwiseOpElement.h")]
public partial class UPCGMetadataBitwiseSettings : UPCGMetadataSettingsBase {
// PCGMetadataBitwiseSettings
	public EPCGMedadataBitwiseOperation Operation;
	public FPCGAttributePropertySelector InputSource1;
	public FPCGAttributePropertySelector InputSource2;
	public string Input1AttributeName_DEPRECATED;
	public string Input2AttributeName_DEPRECATED;
}
