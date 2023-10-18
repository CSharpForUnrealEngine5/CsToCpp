namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/PolygonFunctions.h")]
public partial class UGeometryScriptLibrary_SimplePolygonFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the number of vertices in a Simple Polygon</summary>
	public static int GetPolygonVertexCount(FGeometryScriptSimplePolygon Polygon) { return default; }
	///<summary>Returns the specified vertex of a Simple Polygon. VertexIndex loops around, so e.g., -1 gives the last vertex in the polygon.</summary>
	public static FVector2D GetPolygonVertex(FGeometryScriptSimplePolygon Polygon,int VertexIndex,bool bPolygonIsEmpty) { return default; }
	///<summary>Set the specified vertex of a Simple Polygon. VertexIndex loops around, so e.g., -1 gives the last vertex in the polygon.</summary>
	public static void SetPolygonVertex(FGeometryScriptSimplePolygon Polygon,int VertexIndex,FVector2D Position,bool bPolygonIsEmpty) {}
	///<summary>Set the specified vertex of a Simple Polygon. Returns the index of the added vertex.</summary>
	public static int AddPolygonVertex(FGeometryScriptSimplePolygon Polygon,FVector2D Position) { return default; }
	///<summary>Returns a vertex&#39;s tangent of a Simple Polygon. VertexIndex loops around, so e.g., -1 gives the tangent of the last vertex in the polygon.</summary>
	public static FVector2D GetPolygonTangent(FGeometryScriptSimplePolygon Polygon,int VertexIndex,bool bPolygonIsEmpty) { return default; }
	///<summary>Returns the arc length of a Simple Polygon</summary>
	public static double GetPolygonArcLength(FGeometryScriptSimplePolygon Polygon) { return default; }
	///<summary>Returns the area enclosed by a Simple Polygon</summary>
	public static double GetPolygonArea(FGeometryScriptSimplePolygon Polygon) { return default; }
	///<summary>Returns the bounding box of a Simple Polygon</summary>
	public static FBox2D GetPolygonBounds(FGeometryScriptSimplePolygon Polygon) { return default; }
	///<summary>Sample positions from a USplineComponent into a Simple Polyon, based on the given SamplingOptions</summary>
	public static void ConvertSplineToPolygon(USplineComponent Spline,FGeometryScriptSimplePolygon Polygon,FGeometryScriptSplineSamplingOptions SamplingOptions,EGeometryScriptAxis DropAxis/*=EGeometryScriptAxis.Z*/) {}
	///<summary>Returns an array of 3D vectors with the Polygon vertex locations, with Z coordinate set to zero.</summary>
	public static TArray<FVector> Conv_GeometryScriptSimplePolygonToArray(FGeometryScriptSimplePolygon Polygon) { return default; }
	///<summary>Returns an array of 2D Vectors with the Polygon vertex locations.</summary>
	public static TArray<FVector2D> Conv_GeometryScriptSimplePolygonToArrayOfVector2D(FGeometryScriptSimplePolygon Polygon) { return default; }
	///<summary>Returns a Polygon created from an array of 3D position vectors, ignoring the Z coordinate.</summary>
	public static FGeometryScriptSimplePolygon Conv_ArrayToGeometryScriptSimplePolygon(TArray<FVector> PathVertices) { return default; }
	///<summary>Returns a Polygon created from an array of 2D position vectors.</summary>
	public static FGeometryScriptSimplePolygon Conv_ArrayOfVector2DToGeometryScriptSimplePolygon(TArray<FVector2D> PathVertices) { return default; }
}
