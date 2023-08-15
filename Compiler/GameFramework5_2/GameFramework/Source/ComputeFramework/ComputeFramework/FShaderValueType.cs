namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComputeFramework/ShaderParamTypeDefinition.h")]
public partial struct FShaderValueType {
	public EShaderFundamentalType Type;
	public EShaderFundamentalDimensionType DimensionType;
	public FName Name;
	public bool bIsDynamicArray;
}
