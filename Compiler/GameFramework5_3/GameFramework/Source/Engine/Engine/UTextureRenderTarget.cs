namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TextureRenderTarget.h")]
public partial class UTextureRenderTarget : UTexture {
	public static UClass StaticClass() {return default;}
	///<summary>Will override FTextureRenderTarget2DResource::GetDisplayGamma if &gt; 0.</summary>
	public float TargetGamma;
}
