#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/StaticMeshComponent.h")]
///<summary>Vertex data stored per-LOD</summary>
public partial struct FStaticMeshVertexColorLODData {
// StaticMeshVertexColorLODData
	public TArray<FPaintedVertex> PaintedVertices;
	public TArray<FColor> VertexBufferColors;
	public uint LODIndex;
}
