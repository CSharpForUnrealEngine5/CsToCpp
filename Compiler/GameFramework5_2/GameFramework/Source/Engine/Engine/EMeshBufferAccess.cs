#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Which processors will have access to Mesh Vertex Buffers.</summary>
public enum EMeshBufferAccess {
	Default=0,
	ForceCPUAndGPU=1,
}
