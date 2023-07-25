#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeTextureBackedRenderTarget.h")]
///<summary>A combination of a render target and UTexture2D that allows render target to be saved across save/load/etc</summary>
public partial class ULandscapeTextureBackedRenderTargetBase : UObject {
// LandscapeTextureBackedRenderTargetBase
	public UTextureRenderTarget2D PostLoadRT;
	public UTexture2D InternalTexture;
	public UTextureRenderTarget2D RenderTarget;
	public int SizeX;
	public int SizeY;
	public bool bUseInternalTextureOnly;
}
