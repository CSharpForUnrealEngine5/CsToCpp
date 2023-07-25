#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshVertexPaintingTool.h")]
public partial class UMeshVertexPaintingToolProperties : UBrushBaseProperties {
// MeshVertexPaintingToolProperties
	public FLinearColor PaintColor;
	public FLinearColor EraseColor;
	public bool bEnableFlow;
	public bool bOnlyFrontFacingTriangles;
	public float VertexPreviewSize;
}
