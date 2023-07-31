#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/RendererSettings.h")]
///<summary>Enumerates supported shader compression formats.</summary>
[CppEnumInNamespace]
public enum EShaderCompressionFormat {
	None=0,
	LZ4=1,
	Oodle=2,
	Zlib=3,
}
