#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshTexturePaintingTool.h")]
public partial class UMeshTexturePaintingTool : UBaseBrushTool {
	public static UClass StaticClass() {return default;}
	///<summary>SelectionMechanic</summary>
	public UMeshPaintSelectionMechanic SelectionMechanic;
	///<summary>TextureProperties</summary>
	public UMeshTexturePaintingToolProperties TextureProperties;
	///<summary>Textures</summary>
	public TArray<UTexture> Textures;
	///<summary>Temporary render target used to draw incremental paint to</summary>
	public UTextureRenderTarget2D BrushRenderTargetTexture;
	///<summary>Temporary render target used to store a mask of the affected paint region, updated every time we add incremental texture paint</summary>
	public UTextureRenderTarget2D BrushMaskRenderTargetTexture;
	///<summary>Temporary render target used to store generated mask for texture seams, we create this by projecting object triangles into texture space using the selected UV channel</summary>
	public UTextureRenderTarget2D SeamMaskRenderTargetTexture;
	///<summary>Stores data associated with our paint target textures</summary>
	public TMap<UTexture2D,FPaintTexture2DData> PaintTargetData;
	///<summary>Store the component overrides active for each paint target textures</summary>
	public TMap<UTexture2D,FPaintComponentOverride> PaintComponentsOverride;
	///<summary>Texture paint: The mesh components that we&#39;re currently painting</summary>
	public UMeshComponent TexturePaintingCurrentMeshComponent;
	///<summary>The original texture that we&#39;re painting</summary>
	public UTexture2D PaintingTexture2D;
}
