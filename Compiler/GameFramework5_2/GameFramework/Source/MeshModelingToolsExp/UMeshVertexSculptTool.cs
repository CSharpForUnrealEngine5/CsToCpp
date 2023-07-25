#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshVertexSculptTool.h")]
///<summary>Mesh Vertex Sculpt Tool Class</summary>
public partial class UMeshVertexSculptTool : UMeshSculptToolBase {
// MeshVertexSculptTool
	public UVertexBrushSculptProperties SculptProperties;
	public UVertexBrushAlphaProperties AlphaProperties;
	public UTexture2D BrushAlpha;
	public UMeshSymmetryProperties SymmetryProperties;
	public AInternalToolFrameworkActor PreviewMeshActor;
	public UDynamicMeshComponent DynamicMeshComponent;
}
