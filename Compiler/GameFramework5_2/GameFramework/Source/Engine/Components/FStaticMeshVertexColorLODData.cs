#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Vertex data stored per-LOD</summary>
[CppInclude("Components/StaticMeshComponent.h")]
public partial struct FStaticMeshVertexColorLODData {
	public TArray<FPaintedVertex> PaintedVertices;
	public TArray<FColor> VertexBufferColors;
	public uint LODIndex;
}
