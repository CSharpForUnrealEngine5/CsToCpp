#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeomModifier_Pen.h")]
public partial class UGeomModifier_Pen : UGeomModifier_Edit {
// GeomModifier_Pen
	public bool bAutoExtrude;
	public bool bCreateConvexPolygons;
	public bool bCreateBrushShape;
	public int ExtrudeDepth;
	public TArray<FVector> ShapeVertices;
	public FVector MouseWorldSpacePos;
}
