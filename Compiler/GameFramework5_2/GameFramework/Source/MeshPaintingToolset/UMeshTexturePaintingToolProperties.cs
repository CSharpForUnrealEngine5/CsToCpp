#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshTexturePaintingTool.h")]
public partial class UMeshTexturePaintingToolProperties : UBrushBaseProperties {
// MeshTexturePaintingToolProperties
	public FLinearColor PaintColor;
	public FLinearColor EraseColor;
	public bool bWriteRed;
	public bool bWriteGreen;
	public bool bWriteBlue;
	public bool bWriteAlpha;
	public int UVChannel;
	public bool bEnableSeamPainting;
	public UTexture2D PaintTexture;
	public bool bEnableFlow;
	public bool bOnlyFrontFacingTriangles;
}
