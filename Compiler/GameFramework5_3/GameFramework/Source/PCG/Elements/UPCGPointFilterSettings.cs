namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Point filter that allows to do &quot;A op B&quot; type filtering, where A is the input spatial data,</summary>
[CppInclude("Elements/PCGPointFilter.h")]
public partial class UPCGPointFilterSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Operator</summary>
	public EPCGPointFilterOperator Operator;
	///<summary>Target property/attribute related properties</summary>
	public FPCGAttributePropertyInputSelector TargetAttribute;
	///<summary>Threshold property/attribute/constant related properties</summary>
	public bool bUseConstantThreshold;
	///<summary>ThresholdAttribute</summary>
	public FPCGAttributePropertyInputSelector ThresholdAttribute;
	///<summary>If the threshold data is Point data, it will sample input points in threshold data. Always true with Spatial data.</summary>
	public bool bUseSpatialQuery;
	///<summary>AttributeTypes</summary>
	public FPCGMetadataTypesConstantStruct AttributeTypes;
	///<summary>TargetFilterType_DEPRECATED</summary>
	public EPCGPointTargetFilterType TargetFilterType_DEPRECATED;
	///<summary>TargetPointProperty_DEPRECATED</summary>
	public EPCGPointProperties TargetPointProperty_DEPRECATED;
	///<summary>TargetAttributeName_DEPRECATED</summary>
	public FName TargetAttributeName_DEPRECATED;
	///<summary>ThresholdFilterType_DEPRECATED</summary>
	public EPCGPointThresholdType ThresholdFilterType_DEPRECATED;
	///<summary>ThresholdPointProperty_DEPRECATED</summary>
	public EPCGPointProperties ThresholdPointProperty_DEPRECATED;
	///<summary>ThresholdAttributeName_DEPRECATED</summary>
	public FName ThresholdAttributeName_DEPRECATED;
	///<summary>ThresholdConstantType_DEPRECATED</summary>
	public EPCGPointFilterConstantType ThresholdConstantType_DEPRECATED;
	///<summary>Integer64Constant_DEPRECATED</summary>
	public long Integer64Constant_DEPRECATED;
	///<summary>FloatConstant_DEPRECATED</summary>
	public float FloatConstant_DEPRECATED;
	///<summary>VectorConstant_DEPRECATED</summary>
	public FVector VectorConstant_DEPRECATED;
	///<summary>Vector4Constant_DEPRECATED</summary>
	public FVector4 Vector4Constant_DEPRECATED;
	///<summary>StringConstant_DEPRECATED</summary>
	public string StringConstant_DEPRECATED;
}
