#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComputeFramework/ShaderParamTypeDefinition.h")]
///<summary>Describes how the shader parameters are bound.</summary>
public enum EShaderParamBindingType {
	None=0,
	ConstantParameter=1,
	ReadOnlyResource=2,
	ReadWriteResource=3,
}
