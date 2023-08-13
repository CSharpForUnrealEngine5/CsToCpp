namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Adds an attribute to Spatial data or to an Attribute Set, or creates a new Attribute Set if no</summary>
[CppInclude("Elements/PCGCreateAttribute.h")]
public partial class UPCGCreateAttributeSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>OutputAttributeName</summary>
	public string OutputAttributeName;
	///<summary>bFromSourceParam</summary>
	public bool bFromSourceParam;
	///<summary>This can be set false by inheriting nodes to hide the &#39;From Source Param&#39; property.</summary>
	public bool bDisplayFromSourceParamSetting;
	///<summary>SourceParamAttributeName</summary>
	public string SourceParamAttributeName;
	///<summary>AttributeTypes</summary>
	public FPCGMetadataTypesConstantStruct AttributeTypes;
	///<summary>Type_DEPRECATED</summary>
	public EPCGMetadataTypes Type_DEPRECATED;
	///<summary>FloatValue_DEPRECATED</summary>
	public float FloatValue_DEPRECATED;
	///<summary>Int32Value_DEPRECATED</summary>
	public int Int32Value_DEPRECATED;
	///<summary>DoubleValue_DEPRECATED</summary>
	public double DoubleValue_DEPRECATED;
	///<summary>IntValue_DEPRECATED</summary>
	public long IntValue_DEPRECATED;
	///<summary>Vector2Value_DEPRECATED</summary>
	public FVector2D Vector2Value_DEPRECATED;
	///<summary>VectorValue_DEPRECATED</summary>
	public FVector VectorValue_DEPRECATED;
	///<summary>Vector4Value_DEPRECATED</summary>
	public FVector4 Vector4Value_DEPRECATED;
	///<summary>QuatValue_DEPRECATED</summary>
	public FQuat QuatValue_DEPRECATED;
	///<summary>TransformValue_DEPRECATED</summary>
	public FTransform TransformValue_DEPRECATED;
	///<summary>StringValue_DEPRECATED</summary>
	public string StringValue_DEPRECATED;
	///<summary>BoolValue_DEPRECATED</summary>
	public bool BoolValue_DEPRECATED;
	///<summary>RotatorValue_DEPRECATED</summary>
	public FRotator RotatorValue_DEPRECATED;
	///<summary>NameValue_DEPRECATED</summary>
	public string NameValue_DEPRECATED;
	///<summary>bKeepExistingAttributes_DEPRECATED</summary>
	public bool bKeepExistingAttributes_DEPRECATED;
}
