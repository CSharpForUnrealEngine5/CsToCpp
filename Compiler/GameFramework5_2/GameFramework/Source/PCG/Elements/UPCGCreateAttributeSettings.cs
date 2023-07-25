#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGCreateAttribute.h")]
///<summary>Adds an attribute to Spatial data or to an Attribute Set, or creates a new Attribute Set if no</summary>
public partial class UPCGCreateAttributeSettings : UPCGSettings {
// PCGCreateAttributeSettings
	public string OutputAttributeName;
	public bool bFromSourceParam;
	public bool bDisplayFromSourceParamSetting;
	public string SourceParamAttributeName;
	public FPCGMetadataTypesConstantStruct AttributeTypes;
	public EPCGMetadataTypes Type_DEPRECATED;
	public float FloatValue_DEPRECATED;
	public int Int32Value_DEPRECATED;
	public double DoubleValue_DEPRECATED;
	public long IntValue_DEPRECATED;
	public FVector2D Vector2Value_DEPRECATED;
	public FVector VectorValue_DEPRECATED;
	public FVector4 Vector4Value_DEPRECATED;
	public FQuat QuatValue_DEPRECATED;
	public FTransform TransformValue_DEPRECATED;
	public string StringValue_DEPRECATED;
	public bool BoolValue_DEPRECATED;
	public FRotator RotatorValue_DEPRECATED;
	public string NameValue_DEPRECATED;
	public bool bKeepExistingAttributes_DEPRECATED;
}
