namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TextureRenderTarget2D.h")]
///<summary>Subset of EPixelFormat exposed to UTextureRenderTarget2D</summary>
public enum ETextureRenderTargetFormat {
	RTF_R8=0,
	RTF_RG8=1,
	RTF_RGBA8=2,
	RTF_RGBA8_SRGB=3,
	RTF_R16f=4,
	RTF_RG16f=5,
	RTF_RGBA16f=6,
	RTF_R32f=7,
	RTF_RG32f=8,
	RTF_RGBA32f=9,
	RTF_RGB10A2=10,
}
