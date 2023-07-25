#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComputeFramework/ShaderParamTypeDefinition.h")]
///<summary>Describes a shader function signature.</summary>
public partial struct FShaderFunctionDefinition {
// ShaderFunctionDefinition
	public string Name;
	public TArray<FShaderParamTypeDefinition> ParamTypes;
	public bool bHasReturnType;
}
