#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeTexturePatch.h")]
///<summary>Determines where the patch gets its information, which affects its memory usage in editor (not in runtime,</summary>
public enum ELandscapeTexturePatchSourceMode {
	None=0,
	InternalTexture=1,
	TextureBackedRenderTarget=2,
	TextureAsset=3,
}
