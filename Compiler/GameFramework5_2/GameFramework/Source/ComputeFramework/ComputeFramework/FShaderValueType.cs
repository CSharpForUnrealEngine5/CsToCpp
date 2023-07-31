#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComputeFramework/ShaderParamTypeDefinition.h")]
public partial struct FShaderValueType {
	public EShaderFundamentalType Type;
	public EShaderFundamentalDimensionType DimensionType;
	public string Name;
	public bool bIsDynamicArray;
}
