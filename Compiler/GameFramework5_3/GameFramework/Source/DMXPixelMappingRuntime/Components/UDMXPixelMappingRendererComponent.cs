namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component for rendering input texture.</summary>
[CppInclude("Components/DMXPixelMappingRendererComponent.h")]
public partial class UDMXPixelMappingRendererComponent : UDMXPixelMappingOutputComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the Modulators of the component corresponding to the patch specified.</summary>
	public bool GetPixelMappingComponentModulators(FDMXEntityFixturePatchRef FixturePatchRef,TArray<UDMXModulator> DMXModulators) { return default; }
	///<summary>Type of rendering, Texture, Material, UMG, etc...</summary>
	public EDMXPixelMappingRendererType RendererType;
	///<summary>The texture used for pixel mapping</summary>
	public UTexture InputTexture;
	///<summary>The material used for pixel mapping</summary>
	public UMaterialInterface InputMaterial;
	///<summary>The UMG widget used for pixel mapping</summary>
	public UClass InputWidget;
	///<summary>The brightness of the renderer</summary>
	public float Brightness;
	///<summary>Layout script for the children of this component (hidden in customizations and displayed in its own panel).</summary>
	public UDMXPixelMappingLayoutScript LayoutScript;
	///<summary>The user widget instance currently in use</summary>
	public UUserWidget UserWidget;
	///<summary>Renderer responsible to preprocess the input texture / material / user widget</summary>
	public UDMXPixelMappingPreprocessRenderer PreprocessRenderer;
	///<summary>Renderer responsible to pixel map</summary>
	public UDMXPixelMappingPixelMapRenderer PixelMapRenderer;
	///<summary>DownsampleBufferTarget_DEPRECATED</summary>
	public UTextureRenderTarget2D DownsampleBufferTarget_DEPRECATED;
	///<summary>PreviewRenderTarget_DEPRECATED</summary>
	public UTextureRenderTarget2D PreviewRenderTarget_DEPRECATED;
}
