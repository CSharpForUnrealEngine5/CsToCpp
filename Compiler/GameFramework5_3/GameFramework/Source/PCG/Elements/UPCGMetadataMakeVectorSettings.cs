namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Metadata/PCGMetadataMakeVector.h")]
public partial class UPCGMetadataMakeVectorSettings : UPCGMetadataSettingsBase {
	public static UClass StaticClass() {return default;}
	///<summary>InputSource1</summary>
	public FPCGAttributePropertyInputSelector InputSource1;
	///<summary>InputSource2</summary>
	public FPCGAttributePropertyInputSelector InputSource2;
	///<summary>InputSource3</summary>
	public FPCGAttributePropertyInputSelector InputSource3;
	///<summary>InputSource4</summary>
	public FPCGAttributePropertyInputSelector InputSource4;
	///<summary>OutputType</summary>
	public EPCGMetadataTypes OutputType;
	///<summary>MakeVector3Op</summary>
	public EPCGMetadataMakeVector3 MakeVector3Op;
	///<summary>MakeVector4Op</summary>
	public EPCGMetadataMakeVector4 MakeVector4Op;
	///<summary>Input1AttributeName_DEPRECATED</summary>
	public FName Input1AttributeName_DEPRECATED;
	///<summary>Input2AttributeName_DEPRECATED</summary>
	public FName Input2AttributeName_DEPRECATED;
	///<summary>Input3AttributeName_DEPRECATED</summary>
	public FName Input3AttributeName_DEPRECATED;
	///<summary>Input4AttributeName_DEPRECATED</summary>
	public FName Input4AttributeName_DEPRECATED;
}
