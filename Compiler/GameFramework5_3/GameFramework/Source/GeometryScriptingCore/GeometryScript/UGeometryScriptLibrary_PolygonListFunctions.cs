namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/PolygonFunctions.h")]
public partial class UGeometryScriptLibrary_PolygonListFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the number of polygons in the Polygon List</summary>
	public static int GetPolygonCount(FGeometryScriptGeneralPolygonList PolygonList) { return default; }
	///<summary>Returns the number of holes in a Polygon. Returns zero for an invalid PolygonIndex.</summary>
	public static int GetPolygonHoleCount(FGeometryScriptGeneralPolygonList PolygonList,bool bValidIndex,int PolygonIndex) { return default; }
	///<summary>Returns the number of vertices in a Polygon&#39;s outer shape, if HoleIndex is -1, or in the specified inner hole.</summary>
	public static int GetPolygonVertexCount(FGeometryScriptGeneralPolygonList PolygonList,bool bValidIndices,int PolygonIndex,int HoleIndex/*=-1*/) { return default; }
	///<summary>Returns the vertices of a Polygon -- either of the outer polygon, if HoleIndex is -1, or specified inner hole.</summary>
	public static void GetPolygonVertices(FGeometryScriptGeneralPolygonList PolygonList,TArray<FVector2D> OutVertices,bool bValidIndices,int PolygonIndex,int HoleIndex/*=-1*/) {}
	///<summary>Returns a specified Simple Polygon from a Polygon List -- either the outer polygon, if HoleIndex is -1, or specified inner hole.</summary>
	public static FGeometryScriptSimplePolygon GetSimplePolygon(FGeometryScriptGeneralPolygonList PolygonList,bool bValidIndices,int PolygonIndex,int HoleIndex/*=-1*/) { return default; }
	///<summary>Returns the specified vertex of a Polygon -- either of the outer polygon, if HoleIndex is -1, or specified inner hole.</summary>
	public static FVector2D GetPolygonVertex(FGeometryScriptGeneralPolygonList PolygonList,bool bIsValidVertex,int VertexIndex,int PolygonIndex,int HoleIndex/*=-1*/) { return default; }
	///<summary>Returns the area enclosed by a Polygon. Returns zero for an invalid PolygonIndex.</summary>
	public static double GetPolygonArea(FGeometryScriptGeneralPolygonList PolygonList,bool bValidIndex,int PolygonIndex) { return default; }
	///<summary>Returns the bounding box of a Polygon. Returns an empty, invalid box for an invalid PolygonIndex.</summary>
	public static FBox2D GetPolygonBounds(FGeometryScriptGeneralPolygonList PolygonList,bool bValidIndex,int PolygonIndex) { return default; }
	///<summary>Returns the area enclosed by a Polygon</summary>
	public static double GetPolygonListArea(FGeometryScriptGeneralPolygonList PolygonList) { return default; }
	///<summary>Returns the bounding box of a Polygon</summary>
	public static FBox2D GetPolygonListBounds(FGeometryScriptGeneralPolygonList PolygonList) { return default; }
	///<summary>Create a Polygon List of a single Polygon, with optional holes</summary>
	public static FGeometryScriptGeneralPolygonList CreatePolygonListFromSinglePolygon(FGeometryScriptSimplePolygon OuterPolygon,TArray<FGeometryScriptSimplePolygon> HolePolygons,bool bFixHoleOrientations/*=true*/) { return default; }
	///<summary>Add Polygon to a Polygon List, with optional holes. Returns index of the added polygon.</summary>
	public static int AddPolygonToList(FGeometryScriptGeneralPolygonList PolygonList,FGeometryScriptSimplePolygon OuterPolygon,TArray<FGeometryScriptSimplePolygon> HolePolygons,bool bFixHoleOrientations/*=true*/) { return default; }
	///<summary>Create a Polygon List from an array of Simple Polygons</summary>
	public static FGeometryScriptGeneralPolygonList CreatePolygonListFromSimplePolygons(TArray<FGeometryScriptSimplePolygon> OuterPolygons) { return default; }
	///<summary>Append the polygons in &#39;Polygons to Append&#39; to Polygon List</summary>
	public static void AppendPolygonList(FGeometryScriptGeneralPolygonList PolygonList,FGeometryScriptGeneralPolygonList PolygonsToAppend) {}
	///<summary>Compute union of all polygons in Polygon List. Also resolves self-intersections within each polygon.</summary>
	public static FGeometryScriptGeneralPolygonList PolygonsUnion(FGeometryScriptGeneralPolygonList PolygonList,bool bCopyInputOnFailure/*=true*/) { return default; }
	///<summary>Compute difference of Polygon List and Polygons to Subtract</summary>
	public static FGeometryScriptGeneralPolygonList PolygonsDifference(FGeometryScriptGeneralPolygonList PolygonList,FGeometryScriptGeneralPolygonList PolygonsToSubtract) { return default; }
	///<summary>Compute intersection of Polygon List and Polygons to Intersect</summary>
	public static FGeometryScriptGeneralPolygonList PolygonsIntersection(FGeometryScriptGeneralPolygonList PolygonList,FGeometryScriptGeneralPolygonList PolygonsToIntersect) { return default; }
	///<summary>Compute exclusive or of Polygon List and Polygons to Exclusive Or</summary>
	public static FGeometryScriptGeneralPolygonList PolygonsExclusiveOr(FGeometryScriptGeneralPolygonList PolygonList,FGeometryScriptGeneralPolygonList PolygonsToExclusiveOr) { return default; }
	///<summary>Apply a single offset to a list of closed polygons</summary>
	public static FGeometryScriptGeneralPolygonList PolygonsOffset(FGeometryScriptGeneralPolygonList PolygonList,FGeometryScriptPolygonOffsetOptions OffsetOptions,double Offset,bool bOperationSuccess,bool bCopyInputOnFailure/*=true*/) { return default; }
	///<summary>Apply two offsets in sequence to a list of closed polygons</summary>
	public static FGeometryScriptGeneralPolygonList PolygonsOffsets(FGeometryScriptGeneralPolygonList PolygonList,FGeometryScriptPolygonOffsetOptions OffsetOptions,double FirstOffset,double SecondOffset,bool bOperationSuccess,bool bCopyInputOnFailure/*=true*/) { return default; }
	///<summary>Apply a morphological &quot;open&quot; operator to a list of closed polygons -- first offsetting by -Offset, then by +Offset. If Offset is negative, this will instead function as a &#39;Close&#39; operation</summary>
	public static FGeometryScriptGeneralPolygonList PolygonsMorphologyOpen(FGeometryScriptGeneralPolygonList PolygonList,FGeometryScriptPolygonOffsetOptions OffsetOptions,double Offset,bool bOperationSuccess,bool bCopyInputOnFailure/*=true*/) { return default; }
	///<summary>Apply a morphological &quot;close&quot; operator to a list of closed polygons -- first offsetting by +Offset, then by -Offset. If Offset is negative, this will instead function as an &#39;Open&#39; operation</summary>
	public static FGeometryScriptGeneralPolygonList PolygonsMorphologyClose(FGeometryScriptGeneralPolygonList PolygonList,FGeometryScriptPolygonOffsetOptions OffsetOptions,double Offset,bool bOperationSuccess,bool bCopyInputOnFailure/*=true*/) { return default; }
	///<summary>Apply an offset to a single open 2D path, generating closed polygons as a result</summary>
	public static FGeometryScriptGeneralPolygonList CreatePolygonsFromPathOffset(TArray<FVector2D> Path,FGeometryScriptOpenPathOffsetOptions OffsetOptions,double Offset,bool bOperationSuccess,bool bCopyInputOnFailure/*=true*/) { return default; }
	///<summary>Apply an offset to a set of open 2D PolyPaths, generating closed polygons as a result</summary>
	public static FGeometryScriptGeneralPolygonList CreatePolygonsFromOpenPolyPathsOffset(TArray<FGeometryScriptPolyPath> PolyPaths,FGeometryScriptOpenPathOffsetOptions OffsetOptions,double Offset,bool bOperationSuccess,bool bCopyInputOnFailure/*=true*/) { return default; }
}
