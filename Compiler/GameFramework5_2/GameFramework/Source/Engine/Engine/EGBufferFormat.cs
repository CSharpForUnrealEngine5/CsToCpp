#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Enumerates available GBufferFormats.</summary>
[CppEnumInNamespace]
public enum EGBufferFormat {
	Force8BitsPerChannel=0,
	Default=1,
	HighPrecisionNormals=3,
	Force16BitsPerChannel=5,
}
