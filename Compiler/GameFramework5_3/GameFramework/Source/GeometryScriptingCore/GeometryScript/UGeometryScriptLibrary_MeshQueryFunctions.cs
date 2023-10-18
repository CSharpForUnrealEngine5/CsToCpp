namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshQueryFunctions.h")]
public partial class UGeometryScriptLibrary_MeshQueryFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns information about the Target Mesh, such as the vertex and triangle count as well as some attribute information.</summary>
	public static string GetMeshInfoString(UDynamicMesh TargetMesh) { return default; }
	///<summary>Returns true if the mesh is dense. For example, no gaps in Vertex IDs or Triangle IDs.</summary>
	public static bool GetIsDenseMesh(UDynamicMesh TargetMesh) { return default; }
	///<summary>Returns true if the Target Mesh has attributes enabled.</summary>
	public static bool GetMeshHasAttributeSet(UDynamicMesh TargetMesh) { return default; }
	///<summary>Computes the bounding box of the mesh vertices in the local space of the mesh.</summary>
	public static FBox GetMeshBoundingBox(UDynamicMesh TargetMesh) { return default; }
	///<summary>Computes the volume and area of the mesh.</summary>
	public static void GetMeshVolumeArea(UDynamicMesh TargetMesh,float SurfaceArea,float Volume) {}
	///<summary>Computes the volume, area and center-of-mass of the mesh.</summary>
	public static void GetMeshVolumeAreaCenter(UDynamicMesh TargetMesh,float SurfaceArea,float Volume,FVector CenterOfMass) {}
	///<summary>Returns true if the mesh is closed, such as no topological boundary edges.</summary>
	public static bool GetIsClosedMesh(UDynamicMesh TargetMesh) { return default; }
	///<summary>Returns the number of open border loops, such as &quot;holes&quot; in the mesh.</summary>
	public static int GetNumOpenBorderLoops(UDynamicMesh TargetMesh,bool bAmbiguousTopologyFound) { return default; }
	///<summary>Returns the number of topological boundary edges in the mesh, i.e counts edges that only have one adjacent triangle.</summary>
	public static int GetNumOpenBorderEdges(UDynamicMesh TargetMesh) { return default; }
	///<summary>Returns the number of separate connected components in the mesh, such as &quot;triangle patches&quot; internally connected by shared edges.</summary>
	public static int GetNumConnectedComponents(UDynamicMesh TargetMesh) { return default; }
	///<summary>Gets the number of Triangle IDs in the mesh. This may be larger than the Triangle Count if the mesh is not dense, even after deleting triangles.</summary>
	public static int GetNumTriangleIDs(UDynamicMesh TargetMesh) { return default; }
	///<summary>Returns true if there are gaps in the Triangle ID list, such that Get Num Triangle IDs is greater than Get Triangle Count.</summary>
	public static bool GetHasTriangleIDGaps(UDynamicMesh TargetMesh) { return default; }
	///<summary>Returns true if Triangle ID refers to a valid Triangle in the Target Mesh.</summary>
	public static bool IsValidTriangleID(UDynamicMesh TargetMesh,int TriangleID) { return default; }
	///<summary>Returns an Index List of all Triangle IDs in a mesh.</summary>
	public static UDynamicMesh GetAllTriangleIDs(UDynamicMesh TargetMesh,FGeometryScriptIndexList TriangleIDList,bool bHasTriangleIDGaps) { return default; }
	///<summary>Returns the Vertex ID triplet for the specified Triangle.</summary>
	public static FIntVector GetTriangleIndices(UDynamicMesh TargetMesh,int TriangleID,bool bIsValidTriangle) { return default; }
	///<summary>* Returns a TriangleList of all Triangle Vertex ID triplets in a mesh.</summary>
	public static UDynamicMesh GetAllTriangleIndices(UDynamicMesh TargetMesh,FGeometryScriptTriangleList TriangleList,bool bSkipGaps,bool bHasTriangleIDGaps) { return default; }
	///<summary>* Returns the 3D positions (in the mesh local space) of the three vertices of the requested triangle.</summary>
	public static void GetTrianglePositions(UDynamicMesh TargetMesh,int TriangleID,bool bIsValidTriangle,FVector Vertex1,FVector Vertex2,FVector Vertex3) {}
	///<summary>Compute the interpolated Position (A*Vertex1 + B*Vertex2 + C*Vertex3), where (A,B,C)=BarycentricCoords and the Vertex positions are taken</summary>
	public static UDynamicMesh GetInterpolatedTrianglePosition(UDynamicMesh TargetMesh,int TriangleID,FVector BarycentricCoords,bool bIsValidTriangle,FVector InterpolatedPosition) { return default; }
	///<summary>GetTriangleFaceNormal</summary>
	public static FVector GetTriangleFaceNormal(UDynamicMesh TargetMesh,int TriangleID,bool bIsValidTriangle) { return default; }
	///<summary>Compute the barycentric coordinates (A,B,C) of the Point relative to the specified TriangleID of the TargetMesh.</summary>
	public static UDynamicMesh ComputeTriangleBarycentricCoords(UDynamicMesh TargetMesh,int TriangleID,bool bIsValidTriangle,FVector Point,FVector Vertex1,FVector Vertex2,FVector Vertex3,FVector BarycentricCoords) { return default; }
	///<summary>Gets the number of vertices in the mesh. Note this may be less than the number of Vertex IDs used as some vertices may have been deleted.</summary>
	public static int GetVertexCount(UDynamicMesh TargetMesh) { return default; }
	///<summary>Gets the number of Vertex IDs in the mesh, which may be larger than the Vertex Count, if the mesh is not dense (e.g.  after deleting vertices).</summary>
	public static int GetNumVertexIDs(UDynamicMesh TargetMesh) { return default; }
	///<summary>Returns true if there are gaps in the Vertex ID list. For example, Get Number of Vertex IDs is greater than Get Vertex Count.</summary>
	public static bool GetHasVertexIDGaps(UDynamicMesh TargetMesh) { return default; }
	///<summary>Returns true if Vertex ID refers to a valid vertex in the Target Mesh.</summary>
	public static bool IsValidVertexID(UDynamicMesh TargetMesh,int VertexID) { return default; }
	///<summary>Returns an IndexList of all Vertex IDs in mesh.</summary>
	public static UDynamicMesh GetAllVertexIDs(UDynamicMesh TargetMesh,FGeometryScriptIndexList VertexIDList,bool bHasVertexIDGaps) { return default; }
	///<summary>Gets the 3D position of a mesh vertex in the mesh local space, by Vertex ID.</summary>
	public static FVector GetVertexPosition(UDynamicMesh TargetMesh,int VertexID,bool bIsValidVertex) { return default; }
	///<summary>Returns a Vector List of all the mesh vertex 3D positions (possibly large!).</summary>
	public static UDynamicMesh GetAllVertexPositions(UDynamicMesh TargetMesh,FGeometryScriptVectorList PositionList,bool bSkipGaps,bool bHasVertexIDGaps) { return default; }
	///<summary>Return array of Triangle IDs connected to the given VertexID, ie the triangle one-ring</summary>
	public static UDynamicMesh GetVertexConnectedTriangles(UDynamicMesh TargetMesh,int VertexID,TArray<int> Triangles) { return default; }
	///<summary>Return array of Vertex IDs connected via a mesh edge to the given VertexID, ie the vertex one-ring</summary>
	public static UDynamicMesh GetVertexConnectedVertices(UDynamicMesh TargetMesh,int VertexID,TArray<int> Vertices) { return default; }
	///<summary>Gets the number of UV Channels on the Target Mesh.</summary>
	public static int GetNumUVSets(UDynamicMesh TargetMesh) { return default; }
	///<summary>Gets the 2D bounding box of all UVs in the UV Channel.  If the UV Channel does not exist, or if the UV Channel is empty, the resulting box will be invalid.</summary>
	public static FBox2D GetUVSetBoundingBox(UDynamicMesh TargetMesh,int UVSetIndex,bool bIsValidUVSet,bool bUVSetIsEmpty) { return default; }
	///<summary>Returns the UV values associated with the three vertices of the triangle in the specified UV Channel.</summary>
	public static void GetTriangleUVs(UDynamicMesh TargetMesh,int UVSetIndex,int TriangleID,FVector2D UV1,FVector2D UV2,FVector2D UV3,bool bHaveValidUVs) {}
	///<summary>Returns the unique UV element IDs and values associated with the mesh vertex, in the specified UV Channel.</summary>
	public static UDynamicMesh GetAllSplitUVsAtVertex(UDynamicMesh TargetMesh,int UVSetIndex,int VertexID,TArray<int> ElementIDs,TArray<FVector2D> ElementUVs,bool bHaveValidUVs) { return default; }
	///<summary>Compute the interpolated UV (A*UV1+ B*UV2+ C*UV3), where (A,B,C)=BarycentricCoords and the UV positions are taken</summary>
	public static UDynamicMesh GetInterpolatedTriangleUV(UDynamicMesh TargetMesh,int UVSetIndex,int TriangleID,FVector BarycentricCoords,bool bTriHasValidUVs,FVector2D InterpolatedUV) { return default; }
	///<summary>@return true if the TargetMesh has the Normals Attribute enabled (which allows for storing split normals)</summary>
	public static bool GetHasTriangleNormals(UDynamicMesh TargetMesh) { return default; }
	///<summary>For the specified TriangleID of the Target Mesh, get the Normal vectors at each vertex of the Triangle.</summary>
	public static UDynamicMesh GetTriangleNormals(UDynamicMesh TargetMesh,int TriangleID,FVector Normal1,FVector Normal2,FVector Normal3,bool bTriHasValidNormals) { return default; }
	///<summary>Compute the interpolated Normal (A*Normal1 + B*Normal2 + C*Normal3), where (A,B,C)=BarycentricCoords and the Normals are taken</summary>
	public static UDynamicMesh GetInterpolatedTriangleNormal(UDynamicMesh TargetMesh,int TriangleID,FVector BarycentricCoords,bool bTriHasValidNormals,FVector InterpolatedNormal) { return default; }
	///<summary>For the specified Triangle ID of the TargetMesh, get the Normal and Tangent vectors at each vertex of the Triangle.</summary>
	public static UDynamicMesh GetTriangleNormalTangents(UDynamicMesh TargetMesh,int TriangleID,bool bTriHasValidElements,FGeometryScriptTriangle Normals,FGeometryScriptTriangle Tangents,FGeometryScriptTriangle BiTangents) { return default; }
	///<summary>Compute the interpolated Normal and Tangents for the specified specified TriangleID in the Normal and Tangent attributes of the TargetMesh.</summary>
	public static UDynamicMesh GetInterpolatedTriangleNormalTangents(UDynamicMesh TargetMesh,int TriangleID,FVector BarycentricCoords,bool bTriHasValidElements,FVector InterpolatedNormal,FVector InterpolatedTangent,FVector InterpolatedBiTangent) { return default; }
	///<summary>@return true if the TargetMesh has the Vertex Colors attribute enabled</summary>
	public static bool GetHasVertexColors(UDynamicMesh TargetMesh) { return default; }
	///<summary>For the specified TriangleID of the TargetMesh, get the Vertex Colors at each vertex of the Triangle.</summary>
	public static UDynamicMesh GetTriangleVertexColors(UDynamicMesh TargetMesh,int TriangleID,FLinearColor Color1,FLinearColor Color2,FLinearColor Color3,bool bTriHasValidVertexColors) { return default; }
	///<summary>Compute the interpolated Vertex Color (A*Color1 + B*Color2 + C*Color3), where (A,B,C)=BarycentricCoords and the Colors are taken</summary>
	public static UDynamicMesh GetInterpolatedTriangleVertexColor(UDynamicMesh TargetMesh,int TriangleID,FVector BarycentricCoords,FLinearColor DefaultColor,bool bTriHasValidVertexColors,FLinearColor InterpolatedColor) { return default; }
	///<summary>Returns true if the mesh has Material IDs available/enabled.</summary>
	public static bool GetHasMaterialIDs(UDynamicMesh TargetMesh) { return default; }
	///<summary>Returns true if the mesh has a standard PolyGroup Layer.</summary>
	public static bool GetHasPolygroups(UDynamicMesh TargetMesh) { return default; }
	///<summary>Returns the count of extended PolyGroup Layers.</summary>
	public static int GetNumExtendedPolygroupLayers(UDynamicMesh TargetMesh) { return default; }
}
