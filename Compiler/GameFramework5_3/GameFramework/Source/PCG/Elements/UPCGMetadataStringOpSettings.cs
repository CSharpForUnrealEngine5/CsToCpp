namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Metadata/PCGMetadataStringOpElement.h")]
public partial class UPCGMetadataStringOpSettings : UPCGMetadataSettingsBase {
	public static UClass StaticClass() {return default;}
	///<summary>Operation</summary>
	public EPCGMetadataStringOperation Operation;
	///<summary>InputSource1</summary>
	public FPCGAttributePropertyInputSelector InputSource1;
	///<summary>InputSource2</summary>
	public FPCGAttributePropertyInputSelector InputSource2;
}
