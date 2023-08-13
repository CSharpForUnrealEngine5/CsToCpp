namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Metadata/PCGMetadataMakeTransform.h")]
public partial class UPCGMetadataMakeTransformSettings : UPCGMetadataSettingsBase {
	public static UClass StaticClass() {return default;}
	///<summary>InputSource1</summary>
	public FPCGAttributePropertySelector InputSource1;
	///<summary>InputSource2</summary>
	public FPCGAttributePropertySelector InputSource2;
	///<summary>InputSource3</summary>
	public FPCGAttributePropertySelector InputSource3;
	///<summary>Input1AttributeName_DEPRECATED</summary>
	public string Input1AttributeName_DEPRECATED;
	///<summary>Input2AttributeName_DEPRECATED</summary>
	public string Input2AttributeName_DEPRECATED;
	///<summary>Input3AttributeName_DEPRECATED</summary>
	public string Input3AttributeName_DEPRECATED;
}
