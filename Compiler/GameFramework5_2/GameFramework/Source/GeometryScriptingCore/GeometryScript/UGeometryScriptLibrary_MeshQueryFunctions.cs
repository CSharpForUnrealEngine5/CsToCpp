#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshQueryFunctions.h")]
public partial class UGeometryScriptLibrary_MeshQueryFunctions : UBlueprintFunctionLibrary {
	///<summary>GetMeshInfoString</summary>
	public static string GetMeshInfoString(UDynamicMesh TargetMesh) { return default; }
	///<summary>GetIsDenseMesh</summary>
	public static bool GetIsDenseMesh(UDynamicMesh TargetMesh) { return default; }
	///<summary>GetMeshHasAttributeSet</summary>
	public static bool GetMeshHasAttributeSet(UDynamicMesh TargetMesh) { return default; }
	///<summary>GetMeshBoundingBox</summary>
	public static FBox GetMeshBoundingBox(UDynamicMesh TargetMesh) { return default; }
	///<summary>GetMeshVolumeArea</summary>
	public static void GetMeshVolumeArea(UDynamicMesh TargetMesh,float SurfaceArea,float Volume) {}
	///<summary>GetIsClosedMesh</summary>
	public static bool GetIsClosedMesh(UDynamicMesh TargetMesh) { return default; }
	///<summary>GetNumOpenBorderLoops</summary>
	public static int GetNumOpenBorderLoops(UDynamicMesh TargetMesh,bool bAmbiguousTopologyFound) { return default; }
	///<summary>GetNumOpenBorderEdges</summary>
	public static int GetNumOpenBorderEdges(UDynamicMesh TargetMesh) { return default; }
	///<summary>GetNumConnectedComponents</summary>
	public static int GetNumConnectedComponents(UDynamicMesh TargetMesh) { return default; }
	///<summary>UDynamicMesh already has this function</summary>
	public static int GetNumTriangleIDs(UDynamicMesh TargetMesh) { return default; }
	///<summary>GetHasTriangleIDGaps</summary>
	public static bool GetHasTriangleIDGaps(UDynamicMesh TargetMesh) { return default; }
	///<summary>IsValidTriangleID</summary>
	public static bool IsValidTriangleID(UDynamicMesh TargetMesh,int TriangleID) { return default; }
	///<summary>GetAllTriangleIDs</summary>
	public static UDynamicMesh GetAllTriangleIDs(UDynamicMesh TargetMesh,FGeometryScriptIndexList TriangleIDList,bool bHasTriangleIDGaps) { return default; }
	///<summary>GetTriangleIndices</summary>
	public static FIntVector GetTriangleIndices(UDynamicMesh TargetMesh,int TriangleID,bool bIsValidTriangle) { return default; }
	///<summary>GetAllTriangleIndices</summary>
	public static UDynamicMesh GetAllTriangleIndices(UDynamicMesh TargetMesh,FGeometryScriptTriangleList TriangleList,bool bSkipGaps,bool bHasTriangleIDGaps) { return default; }
	///<summary>GetTrianglePositions</summary>
	public static void GetTrianglePositions(UDynamicMesh TargetMesh,int TriangleID,bool bIsValidTriangle,FVector Vertex1,FVector Vertex2,FVector Vertex3) {}
	///<summary>Compute the interpolated Position (A*Vertex1 + B*Vertex2 + C*Vertex3), where (A,B,C)=BarycentricCoords and the Vertex positions are taken</summary>
	public static UDynamicMesh GetInterpolatedTrianglePosition(UDynamicMesh TargetMesh,int TriangleID,FVector BarycentricCoords,bool bIsValidTriangle,FVector InterpolatedPosition) { return default; }
	///<summary>GetTriangleFaceNormal</summary>
	public static FVector GetTriangleFaceNormal(UDynamicMesh TargetMesh,int TriangleID,bool bIsValidTriangle) { return default; }
	///<summary>Compute the barycentric coordinates (A,B,C) of the Point relative to the specified TriangleID of the TargetMesh.</summary>
	public static UDynamicMesh ComputeTriangleBarycentricCoords(UDynamicMesh TargetMesh,int TriangleID,bool bIsValidTriangle,FVector Point,FVector Vertex1,FVector Vertex2,FVector Vertex3,FVector BarycentricCoords) { return default; }
	///<summary>GetVertexCount</summary>
	public static int GetVertexCount(UDynamicMesh TargetMesh) { return default; }
	///<summary>GetNumVertexIDs</summary>
	public static int GetNumVertexIDs(UDynamicMesh TargetMesh) { return default; }
	///<summary>GetHasVertexIDGaps</summary>
	public static bool GetHasVertexIDGaps(UDynamicMesh TargetMesh) { return default; }
	///<summary>IsValidVertexID</summary>
	public static bool IsValidVertexID(UDynamicMesh TargetMesh,int VertexID) { return default; }
	///<summary>GetAllVertexIDs</summary>
	public static UDynamicMesh GetAllVertexIDs(UDynamicMesh TargetMesh,FGeometryScriptIndexList VertexIDList,bool bHasVertexIDGaps) { return default; }
	///<summary>GetVertexPosition</summary>
	public static FVector GetVertexPosition(UDynamicMesh TargetMesh,int VertexID,bool bIsValidVertex) { return default; }
	///<summary>GetAllVertexPositions</summary>
	public static UDynamicMesh GetAllVertexPositions(UDynamicMesh TargetMesh,FGeometryScriptVectorList PositionList,bool bSkipGaps,bool bHasVertexIDGaps) { return default; }
	///<summary>UV Queries</summary>
	public static int GetNumUVSets(UDynamicMesh TargetMesh) { return default; }
	///<summary>GetUVSetBoundingBox</summary>
	public static FBox2D GetUVSetBoundingBox(UDynamicMesh TargetMesh,int UVSetIndex,bool bIsValidUVSet,bool bUVSetIsEmpty) { return default; }
	///<summary>GetTriangleUVs</summary>
	public static void GetTriangleUVs(UDynamicMesh TargetMesh,int UVSetIndex,int TriangleID,FVector2D UV1,FVector2D UV2,FVector2D UV3,bool bHaveValidUVs) {}
	///<summary>Compute the interpolated UV (A*UV1+ B*UV2+ C*UV3), where (A,B,C)=BarycentricCoords and the UV positions are taken</summary>
	public static UDynamicMesh GetInterpolatedTriangleUV(UDynamicMesh TargetMesh,int UVSetIndex,int TriangleID,FVector BarycentricCoords,bool bTriHasValidUVs,FVector2D InterpolatedUV) { return default; }
	///<summary>@return true if the TargetMesh has the Normals Attribute enabled (which allows for storing split normals)</summary>
	public static bool GetHasTriangleNormals(UDynamicMesh TargetMesh) { return default; }
	///<summary>For the specified TriangleID of the TargetMesh, get the Normal vectors at each vertex of the Triangle.</summary>
	public static UDynamicMesh GetTriangleNormals(UDynamicMesh TargetMesh,int TriangleID,FVector Normal1,FVector Normal2,FVector Normal3,bool bTriHasValidNormals) { return default; }
	///<summary>Compute the interpolated Normal (A*Normal1 + B*Normal2 + C*Normal3), where (A,B,C)=BarycentricCoords and the Normals are taken</summary>
	public static UDynamicMesh GetInterpolatedTriangleNormal(UDynamicMesh TargetMesh,int TriangleID,FVector BarycentricCoords,bool bTriHasValidNormals,FVector InterpolatedNormal) { return default; }
	///<summary>For the specified TriangleID of the TargetMesh, get the Normal and Tangent vectors at each vertex of the Triangle.</summary>
	public static UDynamicMesh GetTriangleNormalTangents(UDynamicMesh TargetMesh,int TriangleID,bool bTriHasValidElements,FGeometryScriptTriangle Normals,FGeometryScriptTriangle Tangents,FGeometryScriptTriangle BiTangents) { return default; }
	///<summary>Compute the interpolated Normal and Tangents for the specified specified TriangleID in the Normal and Tangent attributes of the TargetMesh.</summary>
	public static UDynamicMesh GetInterpolatedTriangleNormalTangents(UDynamicMesh TargetMesh,int TriangleID,FVector BarycentricCoords,bool bTriHasValidElements,FVector InterpolatedNormal,FVector InterpolatedTangent,FVector InterpolatedBiTangent) { return default; }
	///<summary>@return true if the TargetMesh has the Vertex Colors attribute enabled</summary>
	public static bool GetHasVertexColors(UDynamicMesh TargetMesh) { return default; }
	///<summary>For the specified TriangleID of the TargetMesh, get the Vertex Colors at each vertex of the Triangle.</summary>
	public static UDynamicMesh GetTriangleVertexColors(UDynamicMesh TargetMesh,int TriangleID,FLinearColor Color1,FLinearColor Color2,FLinearColor Color3,bool bTriHasValidVertexColors) { return default; }
	///<summary>Compute the interpolated Vertex Color (A*Color1 + B*Color2 + C*Color3), where (A,B,C)=BarycentricCoords and the Colors are taken</summary>
	public static UDynamicMesh GetInterpolatedTriangleVertexColor(UDynamicMesh TargetMesh,int TriangleID,FVector BarycentricCoords,FLinearColor DefaultColor,bool bTriHasValidVertexColors,FLinearColor InterpolatedColor) { return default; }
	///<summary>Material Queries</summary>
	public static bool GetHasMaterialIDs(UDynamicMesh TargetMesh) { return default; }
	///<summary>Polygroup Queries</summary>
	public static bool GetHasPolygroups(UDynamicMesh TargetMesh) { return default; }
	///<summary>GetNumExtendedPolygroupLayers</summary>
	public static int GetNumExtendedPolygroupLayers(UDynamicMesh TargetMesh) { return default; }
}
