namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Metadata/PCGMetadataElement.h")]
public partial class UPCGMetadataOperationSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>InputSource</summary>
	public FPCGAttributePropertyInputSelector InputSource;
	///<summary>OutputTarget</summary>
	public FPCGAttributePropertyOutputSelector OutputTarget;
	///<summary>SourceAttribute_DEPRECATED</summary>
	public FName SourceAttribute_DEPRECATED;
	///<summary>PointProperty_DEPRECATED</summary>
	public EPCGPointProperties PointProperty_DEPRECATED;
	///<summary>DestinationAttribute_DEPRECATED</summary>
	public FName DestinationAttribute_DEPRECATED;
	///<summary>Target_DEPRECATED</summary>
	public EPCGMetadataOperationTarget Target_DEPRECATED;
}
