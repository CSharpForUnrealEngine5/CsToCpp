#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComputeFramework/ShaderParamTypeDefinition.h")]
///<summary>Fully describes the name and type of a parameter a shader exposes.</summary>
public partial struct FShaderParamTypeDefinition {
// ShaderParamTypeDefinition
	public string TypeDeclaration;
	public string Name;
	public FShaderValueTypeHandle ValueType;
	public ushort ArrayElementCount;
	public EShaderParamBindingType BindingType;
	public EShaderResourceType ResourceType;
}
