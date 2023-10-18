namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes a shader function signature.</summary>
[CppInclude("ComputeFramework/ShaderParamTypeDefinition.h")]
public partial struct FShaderFunctionDefinition {
	public string Name;
	public TArray<FShaderParamTypeDefinition> ParamTypes;
	public bool bHasReturnType;
}
