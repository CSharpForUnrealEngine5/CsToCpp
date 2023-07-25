#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialInstance.h")]
public partial struct FScalarParameterValue {
// ScalarParameterValue
	public string ParameterName_DEPRECATED;
	public FScalarParameterAtlasInstanceData AtlasData;
	public FMaterialParameterInfo ParameterInfo;
	public float ParameterValue;
	public FGuid ExpressionGUID;
}
