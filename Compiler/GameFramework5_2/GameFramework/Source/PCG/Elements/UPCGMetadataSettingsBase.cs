#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all Metadata operations.</summary>
[CppInclude("Elements/Metadata/PCGMetadataOpElementBase.h")]
public partial class UPCGMetadataSettingsBase : UPCGSettings {
	///<summary>OutputTarget</summary>
	public FPCGAttributePropertySelector OutputTarget;
	///<summary>OutputAttributeName_DEPRECATED</summary>
	public string OutputAttributeName_DEPRECATED;
	///<summary>Mode_DEPRECATED</summary>
	public EPCGMetadataSettingsBaseMode Mode_DEPRECATED;
}
