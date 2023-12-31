namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/RendererSettings.h")]
///<summary>Enumerates available options for alpha channel through post processing. The renderer will always generate premultiplied RGBA</summary>
[CppEnumInNamespace]
public enum EAlphaChannelMode {
	Disabled=0,
	LinearColorSpaceOnly=1,
	AllowThroughTonemapper=2,
}
