namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialInstance.h")]
public partial struct FScalarParameterValue {
	public string ParameterName_DEPRECATED;
	public FScalarParameterAtlasInstanceData AtlasData;
	public FMaterialParameterInfo ParameterInfo;
	public float ParameterValue;
	public FGuid ExpressionGUID;
}
