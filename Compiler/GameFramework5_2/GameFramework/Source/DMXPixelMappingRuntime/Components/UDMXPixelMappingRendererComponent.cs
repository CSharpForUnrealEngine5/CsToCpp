#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component for rendering input texture.</summary>
[CppInclude("Components/DMXPixelMappingRendererComponent.h")]
public partial class UDMXPixelMappingRendererComponent : UDMXPixelMappingOutputComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Render input texture for downsampling</summary>
	public  void RendererInputTexture() {}
	///<summary>Returns the Modulators of the component corresponding to the patch specified.</summary>
	public  bool GetPixelMappingComponentModulators(FDMXEntityFixturePatchRef FixturePatchRef,TArray<UDMXModulator> DMXModulators) { return default; }
	///<summary>Type of rendering, Texture, Material, UMG, etc...</summary>
	public EDMXPixelMappingRendererType RendererType;
	///<summary>Texture to Downsampling</summary>
	public UTexture InputTexture;
	///<summary>Material to Downsampling</summary>
	public UMaterialInterface InputMaterial;
	///<summary>UMG to Downsampling</summary>
	public UClass InputWidget;
	///<summary>The brightness of the renderer</summary>
	public float Brightness;
	///<summary>Layout script for the children of this component (hidden in customizations and displayed in its own panel).</summary>
	public UDMXPixelMappingLayoutScript LayoutScript;
	///<summary>Editor preview output target</summary>
	public UTextureRenderTarget2D PreviewRenderTarget;
	///<summary>Material of UMG texture to downsample</summary>
	public UTextureRenderTarget2D InputRenderTarget;
	///<summary>UMG widget for downsampling</summary>
	public UUserWidget UserWidget;
	///<summary>GPU downsample pixel buffer target texture</summary>
	public UTextureRenderTarget2D DownsampleBufferTarget;
}
