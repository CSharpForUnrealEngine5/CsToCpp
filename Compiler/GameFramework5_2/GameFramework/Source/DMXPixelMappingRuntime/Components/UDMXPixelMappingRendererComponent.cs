#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/DMXPixelMappingRendererComponent.h")]
///<summary>Component for rendering input texture.</summary>
public partial class UDMXPixelMappingRendererComponent : UDMXPixelMappingOutputComponent {
// DMXPixelMappingRendererComponent
	public  void RendererInputTexture() {}
	public  bool GetPixelMappingComponentModulators(FDMXEntityFixturePatchRef FixturePatchRef,TArray<UDMXModulator> DMXModulators) { return default; }
	public EDMXPixelMappingRendererType RendererType;
	public UTexture InputTexture;
	public UMaterialInterface InputMaterial;
	public UClass InputWidget;
	public float Brightness;
	public UDMXPixelMappingLayoutScript LayoutScript;
	public UTextureRenderTarget2D PreviewRenderTarget;
	public UTextureRenderTarget2D InputRenderTarget;
	public UUserWidget UserWidget;
	public UTextureRenderTarget2D DownsampleBufferTarget;
}
