#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/RendererSettings.h")]
///<summary>used by GetDefaultBackBufferPixelFormat</summary>
[CppEnumInNamespace]
public enum EDefaultBackBufferPixelFormat {
	DBBPF_B8G8R8A8=0,
	DBBPF_A16B16G16R16_DEPRECATED=1,
	DBBPF_FloatRGB_DEPRECATED=2,
	DBBPF_FloatRGBA=3,
	DBBPF_A2B10G10R10=4,
	DBBPF_MAX=5,
}
