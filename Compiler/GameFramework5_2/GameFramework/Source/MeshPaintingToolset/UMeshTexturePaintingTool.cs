#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshTexturePaintingTool.h")]
public partial class UMeshTexturePaintingTool : UBaseBrushTool {
// MeshTexturePaintingTool
	public UMeshPaintSelectionMechanic SelectionMechanic;
	public UMeshTexturePaintingToolProperties TextureProperties;
	public TArray<UTexture> Textures;
	public UTextureRenderTarget2D BrushRenderTargetTexture;
	public UTextureRenderTarget2D BrushMaskRenderTargetTexture;
	public UTextureRenderTarget2D SeamMaskRenderTargetTexture;
	public TMap<UTexture2D,FPaintTexture2DData> PaintTargetData;
	public TMap<UTexture2D,FPaintComponentOverride> PaintComponentsOverride;
	public UMeshComponent TexturePaintingCurrentMeshComponent;
	public UTexture2D PaintingTexture2D;
}
