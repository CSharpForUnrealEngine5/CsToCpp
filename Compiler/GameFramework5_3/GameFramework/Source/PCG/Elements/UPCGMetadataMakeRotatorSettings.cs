namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Create a Rotator from 1, 2 or 3 axis.</summary>
[CppInclude("Elements/Metadata/PCGMetadataMakeRotator.h")]
public partial class UPCGMetadataMakeRotatorSettings : UPCGMetadataSettingsBase {
	public static UClass StaticClass() {return default;}
	///<summary>InputSource1</summary>
	public FPCGAttributePropertyInputSelector InputSource1;
	///<summary>InputSource2</summary>
	public FPCGAttributePropertyInputSelector InputSource2;
	///<summary>InputSource3</summary>
	public FPCGAttributePropertyInputSelector InputSource3;
	///<summary>Operation</summary>
	public EPCGMetadataMakeRotatorOp Operation;
}
