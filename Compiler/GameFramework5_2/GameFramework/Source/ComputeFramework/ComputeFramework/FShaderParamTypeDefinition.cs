#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Fully describes the name and type of a parameter a shader exposes.</summary>
[CppInclude("ComputeFramework/ShaderParamTypeDefinition.h")]
public partial struct FShaderParamTypeDefinition {
	public string TypeDeclaration;
	public string Name;
	public FShaderValueTypeHandle ValueType;
	public ushort ArrayElementCount;
	public EShaderParamBindingType BindingType;
	public EShaderResourceType ResourceType;
}
