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
