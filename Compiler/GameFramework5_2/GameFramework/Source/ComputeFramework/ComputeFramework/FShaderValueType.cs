namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComputeFramework/ShaderParamTypeDefinition.h")]
public partial struct FShaderValueType {
	public EShaderFundamentalType Type;
	public EShaderFundamentalDimensionType DimensionType;
	public string Name;
	public bool bIsDynamicArray;
}
