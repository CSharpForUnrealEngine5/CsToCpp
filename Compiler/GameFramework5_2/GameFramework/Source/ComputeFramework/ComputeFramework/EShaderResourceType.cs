#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComputeFramework/ShaderParamTypeDefinition.h")]
public enum EShaderResourceType {
	None=0,
	Texture1D=1,
	Texture2D=2,
	Texture3D=3,
	TextureCube=4,
	Buffer=5,
	StructuredBuffer=6,
	ByteAddressBuffer=7,
}
