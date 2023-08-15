namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all Metadata operations.</summary>
[CppInclude("Elements/Metadata/PCGMetadataOpElementBase.h")]
public partial class UPCGMetadataSettingsBase : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>OutputTarget</summary>
	public FPCGAttributePropertySelector OutputTarget;
	///<summary>OutputAttributeName_DEPRECATED</summary>
	public FName OutputAttributeName_DEPRECATED;
	///<summary>Mode_DEPRECATED</summary>
	public EPCGMetadataSettingsBaseMode Mode_DEPRECATED;
}
