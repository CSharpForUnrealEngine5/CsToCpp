namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Output/VCamOutputComposure.h")]
public partial class UVCamOutputComposure : UVCamOutputProviderBase {
	public static UClass StaticClass() {return default;}
	///<summary>List of Composure stack Compositing Elements to render the requested UMG into</summary>
	public TArray<TSoftObjectPtr<ACompositingElement>> LayerTargets;
	///<summary>TextureRenderTarget2D asset that contains the final output</summary>
	public UTextureRenderTarget2D FinalOutputRenderTarget;
}
