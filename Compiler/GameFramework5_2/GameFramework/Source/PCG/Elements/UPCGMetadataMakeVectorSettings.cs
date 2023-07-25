#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Metadata/PCGMetadataMakeVector.h")]
public partial class UPCGMetadataMakeVectorSettings : UPCGMetadataSettingsBase {
// PCGMetadataMakeVectorSettings
	public FPCGAttributePropertySelector InputSource1;
	public FPCGAttributePropertySelector InputSource2;
	public FPCGAttributePropertySelector InputSource3;
	public FPCGAttributePropertySelector InputSource4;
	public EPCGMetadataTypes OutputType;
	public EPCGMetadataMakeVector3 MakeVector3Op;
	public EPCGMetadataMakeVector4 MakeVector4Op;
	public string Input1AttributeName_DEPRECATED;
	public string Input2AttributeName_DEPRECATED;
	public string Input3AttributeName_DEPRECATED;
	public string Input4AttributeName_DEPRECATED;
}
