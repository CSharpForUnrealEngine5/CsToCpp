#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComputeFramework/ShaderParamTypeDefinition.h")]
public partial struct FShaderValueType {
// ShaderValueType
	public EShaderFundamentalType Type;
	public EShaderFundamentalDimensionType DimensionType;
	public string Name;
	public bool bIsDynamicArray;
}
