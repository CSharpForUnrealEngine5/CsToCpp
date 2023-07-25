#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGPointFilter.h")]
///<summary>Point filter that allows to do "A op B" type filtering, where A is the input spatial data,</summary>
public partial class UPCGPointFilterSettings : UPCGSettings {
// PCGPointFilterSettings
	public EPCGPointFilterOperator Operator;
	public FPCGAttributePropertySelector TargetAttribute;
	public bool bUseConstantThreshold;
	public FPCGAttributePropertySelector ThresholdAttribute;
	public bool bUseSpatialQuery;
	public FPCGMetadataTypesConstantStruct AttributeTypes;
	public EPCGPointTargetFilterType TargetFilterType_DEPRECATED;
	public EPCGPointProperties TargetPointProperty_DEPRECATED;
	public string TargetAttributeName_DEPRECATED;
	public EPCGPointThresholdType ThresholdFilterType_DEPRECATED;
	public EPCGPointProperties ThresholdPointProperty_DEPRECATED;
	public string ThresholdAttributeName_DEPRECATED;
	public EPCGPointFilterConstantType ThresholdConstantType_DEPRECATED;
	public long Integer64Constant_DEPRECATED;
	public float FloatConstant_DEPRECATED;
	public FVector VectorConstant_DEPRECATED;
	public FVector4 Vector4Constant_DEPRECATED;
	public string StringConstant_DEPRECATED;
}
