#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Metadata/PCGMetadataElement.h")]
public partial class UPCGMetadataOperationSettings : UPCGSettings {
	///<summary>InputSource</summary>
	public FPCGAttributePropertySelector InputSource;
	///<summary>OutputTarget</summary>
	public FPCGAttributePropertySelector OutputTarget;
	///<summary>SourceAttribute_DEPRECATED</summary>
	public string SourceAttribute_DEPRECATED;
	///<summary>PointProperty_DEPRECATED</summary>
	public EPCGPointProperties PointProperty_DEPRECATED;
	///<summary>DestinationAttribute_DEPRECATED</summary>
	public string DestinationAttribute_DEPRECATED;
	///<summary>Target_DEPRECATED</summary>
	public EPCGMetadataOperationTarget Target_DEPRECATED;
}
