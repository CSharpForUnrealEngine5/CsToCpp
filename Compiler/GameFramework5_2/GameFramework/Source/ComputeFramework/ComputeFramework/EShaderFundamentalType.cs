#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComputeFramework/ShaderParamTypeDefinition.h")]
///<summary>The base types of data that shaders can consume/expose</summary>
public enum EShaderFundamentalType {
	Bool=0,
	Int=1,
	Uint=2,
	Float=3,
	Struct=4,
	None=255,
}
