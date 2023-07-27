#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshQueryFunctions.h")]
public partial class UGeometryScriptLibrary_MeshQueryFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshQueryFunctions
	public static string GetMeshInfoString(UDynamicMesh TargetMesh) { return default; }
	public static bool GetIsDenseMesh(UDynamicMesh TargetMesh) { return default; }
	public static bool GetMeshHasAttributeSet(UDynamicMesh TargetMesh) { return default; }
	public static FBox GetMeshBoundingBox(UDynamicMesh TargetMesh) { return default; }
	public static void GetMeshVolumeArea(UDynamicMesh TargetMesh,float SurfaceArea,float Volume) {}
	public static bool GetIsClosedMesh(UDynamicMesh TargetMesh) { return default; }
	public static int GetNumOpenBorderLoops(UDynamicMesh TargetMesh,bool bAmbiguousTopologyFound) { return default; }
	public static int GetNumOpenBorderEdges(UDynamicMesh TargetMesh) { return default; }
	public static int GetNumConnectedComponents(UDynamicMesh TargetMesh) { return default; }
	public static int GetNumTriangleIDs(UDynamicMesh TargetMesh) { return default; }
	public static bool GetHasTriangleIDGaps(UDynamicMesh TargetMesh) { return default; }
	public static bool IsValidTriangleID(UDynamicMesh TargetMesh,int TriangleID) { return default; }
	public static UDynamicMesh GetAllTriangleIDs(UDynamicMesh TargetMesh,FGeometryScriptIndexList TriangleIDList,bool bHasTriangleIDGaps) { return default; }
	public static FIntVector GetTriangleIndices(UDynamicMesh TargetMesh,int TriangleID,bool bIsValidTriangle) { return default; }
	public static UDynamicMesh GetAllTriangleIndices(UDynamicMesh TargetMesh,FGeometryScriptTriangleList TriangleList,bool bSkipGaps,bool bHasTriangleIDGaps) { return default; }
	public static void GetTrianglePositions(UDynamicMesh TargetMesh,int TriangleID,bool bIsValidTriangle,FVector Vertex1,FVector Vertex2,FVector Vertex3) {}
	public static UDynamicMesh GetInterpolatedTrianglePosition(UDynamicMesh TargetMesh,int TriangleID,FVector BarycentricCoords,bool bIsValidTriangle,FVector InterpolatedPosition) { return default; }
	public static FVector GetTriangleFaceNormal(UDynamicMesh TargetMesh,int TriangleID,bool bIsValidTriangle) { return default; }
	public static UDynamicMesh ComputeTriangleBarycentricCoords(UDynamicMesh TargetMesh,int TriangleID,bool bIsValidTriangle,FVector Point,FVector Vertex1,FVector Vertex2,FVector Vertex3,FVector BarycentricCoords) { return default; }
	public static int GetVertexCount(UDynamicMesh TargetMesh) { return default; }
	public static int GetNumVertexIDs(UDynamicMesh TargetMesh) { return default; }
	public static bool GetHasVertexIDGaps(UDynamicMesh TargetMesh) { return default; }
	public static bool IsValidVertexID(UDynamicMesh TargetMesh,int VertexID) { return default; }
	public static UDynamicMesh GetAllVertexIDs(UDynamicMesh TargetMesh,FGeometryScriptIndexList VertexIDList,bool bHasVertexIDGaps) { return default; }
	public static FVector GetVertexPosition(UDynamicMesh TargetMesh,int VertexID,bool bIsValidVertex) { return default; }
	public static UDynamicMesh GetAllVertexPositions(UDynamicMesh TargetMesh,FGeometryScriptVectorList PositionList,bool bSkipGaps,bool bHasVertexIDGaps) { return default; }
	public static int GetNumUVSets(UDynamicMesh TargetMesh) { return default; }
	public static FBox2D GetUVSetBoundingBox(UDynamicMesh TargetMesh,int UVSetIndex,bool bIsValidUVSet,bool bUVSetIsEmpty) { return default; }
	public static void GetTriangleUVs(UDynamicMesh TargetMesh,int UVSetIndex,int TriangleID,FVector2D UV1,FVector2D UV2,FVector2D UV3,bool bHaveValidUVs) {}
	public static UDynamicMesh GetInterpolatedTriangleUV(UDynamicMesh TargetMesh,int UVSetIndex,int TriangleID,FVector BarycentricCoords,bool bTriHasValidUVs,FVector2D InterpolatedUV) { return default; }
	public static bool GetHasTriangleNormals(UDynamicMesh TargetMesh) { return default; }
	public static UDynamicMesh GetTriangleNormals(UDynamicMesh TargetMesh,int TriangleID,FVector Normal1,FVector Normal2,FVector Normal3,bool bTriHasValidNormals) { return default; }
	public static UDynamicMesh GetInterpolatedTriangleNormal(UDynamicMesh TargetMesh,int TriangleID,FVector BarycentricCoords,bool bTriHasValidNormals,FVector InterpolatedNormal) { return default; }
	public static UDynamicMesh GetTriangleNormalTangents(UDynamicMesh TargetMesh,int TriangleID,bool bTriHasValidElements,FGeometryScriptTriangle Normals,FGeometryScriptTriangle Tangents,FGeometryScriptTriangle BiTangents) { return default; }
	public static UDynamicMesh GetInterpolatedTriangleNormalTangents(UDynamicMesh TargetMesh,int TriangleID,FVector BarycentricCoords,bool bTriHasValidElements,FVector InterpolatedNormal,FVector InterpolatedTangent,FVector InterpolatedBiTangent) { return default; }
	public static bool GetHasVertexColors(UDynamicMesh TargetMesh) { return default; }
	public static UDynamicMesh GetTriangleVertexColors(UDynamicMesh TargetMesh,int TriangleID,FLinearColor Color1,FLinearColor Color2,FLinearColor Color3,bool bTriHasValidVertexColors) { return default; }
	public static UDynamicMesh GetInterpolatedTriangleVertexColor(UDynamicMesh TargetMesh,int TriangleID,FVector BarycentricCoords,FLinearColor DefaultColor,bool bTriHasValidVertexColors,FLinearColor InterpolatedColor) { return default; }
	public static bool GetHasMaterialIDs(UDynamicMesh TargetMesh) { return default; }
	public static bool GetHasPolygroups(UDynamicMesh TargetMesh) { return default; }
	public static int GetNumExtendedPolygroupLayers(UDynamicMesh TargetMesh) { return default; }
}
