#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshVertexPaintingTool.h")]
public partial class UMeshVertexPaintingToolProperties : UBrushBaseProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Color used for Applying Vertex Color Painting</summary>
	public FLinearColor PaintColor;
	///<summary>Color used for Erasing Vertex Color Painting</summary>
	public FLinearColor EraseColor;
	///<summary>Enables &quot;Flow&quot; painting where paint is continually applied from the brush every tick</summary>
	public bool bEnableFlow;
	///<summary>Whether back-facing triangles should be ignored</summary>
	public bool bOnlyFrontFacingTriangles;
	///<summary>Size of vertex points drawn when mesh painting is active.</summary>
	public float VertexPreviewSize;
}
