#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshVertexPainter/MeshVertexPainterKismetLibrary.h")]
public partial class UMeshVertexPainterKismetLibrary : UBlueprintFunctionLibrary {
// MeshVertexPainterKismetLibrary
	public void PaintVerticesSingleColor(UObject StaticMeshComponent,FLinearColor FillColor,bool bConvertToSRGB/*=true*/) {}
	public void PaintVerticesLerpAlongAxis(UObject StaticMeshComponent,FLinearColor StartColor,FLinearColor EndColor,EVertexPaintAxis Axis,bool bConvertToSRGB/*=true*/) {}
	public void RemovePaintedVertices(UObject StaticMeshComponent) {}
}
