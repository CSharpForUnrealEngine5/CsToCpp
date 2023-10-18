namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshVertexPainter/MeshVertexPainterKismetLibrary.h")]
public partial class UMeshVertexPainterKismetLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Paints vertex colors on a mesh component in a specified color.</summary>
	public static void PaintVerticesSingleColor(UStaticMeshComponent StaticMeshComponent,FLinearColor FillColor,bool bConvertToSRGB/*=true*/) {}
	///<summary>Paints vertex colors on a mesh component lerping from the start to the end color along the specified axis.</summary>
	public static void PaintVerticesLerpAlongAxis(UStaticMeshComponent StaticMeshComponent,FLinearColor StartColor,FLinearColor EndColor,EVertexPaintAxis Axis,bool bConvertToSRGB/*=true*/) {}
	///<summary>Removes vertex colors on a mesh component</summary>
	public static void RemovePaintedVertices(UStaticMeshComponent StaticMeshComponent) {}
}
