#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshPaintingToolsetTypes.h")]
public partial struct FPaintTexture2DData {
	public UTexture2D PaintingTexture2D;
	public bool bIsPaintingTexture2DModified;
	public UTexture2D ScratchTexture;
	public UTextureRenderTarget2D PaintRenderTargetTexture;
	public TArray<UMeshComponent> PaintedComponents;
}
