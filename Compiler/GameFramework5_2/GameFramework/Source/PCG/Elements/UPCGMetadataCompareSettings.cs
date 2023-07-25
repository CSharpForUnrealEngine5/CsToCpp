#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Metadata/PCGMetadataCompareOpElement.h")]
public partial class UPCGMetadataCompareSettings : UPCGMetadataSettingsBase {
// PCGMetadataCompareSettings
	public EPCGMedadataCompareOperation Operation;
	public FPCGAttributePropertySelector InputSource1;
	public FPCGAttributePropertySelector InputSource2;
	public double Tolerance;
	public string Input1AttributeName_DEPRECATED;
	public string Input2AttributeName_DEPRECATED;
}
