#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshVertexPainter/MeshVertexPainterKismetLibrary.h")]
public partial class UMeshVertexPainterKismetLibrary : UBlueprintFunctionLibrary {
// MeshVertexPainterKismetLibrary
	public static void PaintVerticesSingleColor(UStaticMeshComponent StaticMeshComponent,FLinearColor FillColor,bool bConvertToSRGB/*=true*/) {}
	public static void PaintVerticesLerpAlongAxis(UStaticMeshComponent StaticMeshComponent,FLinearColor StartColor,FLinearColor EndColor,EVertexPaintAxis Axis,bool bConvertToSRGB/*=true*/) {}
	public static void RemovePaintedVertices(UStaticMeshComponent StaticMeshComponent) {}
}
