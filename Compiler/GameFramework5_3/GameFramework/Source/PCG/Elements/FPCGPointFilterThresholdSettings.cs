namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGPointFilter.h")]
public partial struct FPCGPointFilterThresholdSettings {
	public bool bInclusive;
	public bool bUseConstantThreshold;
	public FPCGAttributePropertyInputSelector ThresholdAttribute;
	public bool bUseSpatialQuery;
	public FPCGMetadataTypesConstantStruct AttributeTypes;
}
