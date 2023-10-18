namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A combination of a render target and UTexture2D that allows render target to be saved across save/load/etc</summary>
[CppInclude("LandscapeTextureBackedRenderTarget.h")]
public partial class ULandscapeTextureBackedRenderTargetBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>PostLoadRT</summary>
	public UTextureRenderTarget2D PostLoadRT;
	///<summary>InternalTexture</summary>
	public UTexture2D InternalTexture;
	///<summary>RenderTarget</summary>
	public UTextureRenderTarget2D RenderTarget;
	///<summary>SizeX</summary>
	public int SizeX;
	///<summary>SizeY</summary>
	public int SizeY;
	///<summary>bUseInternalTextureOnly</summary>
	public bool bUseInternalTextureOnly;
}
