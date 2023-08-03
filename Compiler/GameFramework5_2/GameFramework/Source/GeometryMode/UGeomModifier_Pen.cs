#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeomModifier_Pen.h")]
public partial class UGeomModifier_Pen : UGeomModifier_Edit {
	public static UClass StaticClass() {return default;}
	///<summary>If true, the shape will be automatically extruded into a brush upon completion.</summary>
	public bool bAutoExtrude;
	///<summary>If true, the tool will try and optimize the resulting triangles into convex polygons before creating the brush.</summary>
	public bool bCreateConvexPolygons;
	///<summary>If true, the resulting shape will be turned into an ABrushShape actor.</summary>
	public bool bCreateBrushShape;
	///<summary>How far to extrude the newly created brush if bAutoExtrude is set to true.</summary>
	public int ExtrudeDepth;
	///<summary>The vertices that the user has dropped down in the world so far.</summary>
	public TArray<FVector> ShapeVertices;
	///<summary>The mouse position, in world space, where the user currently is hovering (snapped to grid if that setting is enabled).</summary>
	public FVector MouseWorldSpacePos;
}
