#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshQueryFunctions.h")]
public partial class UGeometryScriptLibrary_MeshQueryFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshQueryFunctions
	public string GetMeshInfoString(UObject TargetMesh) { return default; }
	public bool GetIsDenseMesh(UObject TargetMesh) { return default; }
	public bool GetMeshHasAttributeSet(UObject TargetMesh) { return default; }
	public FBox GetMeshBoundingBox(UObject TargetMesh) { return default; }
	public void GetMeshVolumeArea(UObject TargetMesh,float SurfaceArea,float Volume) {}
	public bool GetIsClosedMesh(UObject TargetMesh) { return default; }
	public int GetNumOpenBorderLoops(UObject TargetMesh,bool bAmbiguousTopologyFound) { return default; }
	public int GetNumOpenBorderEdges(UObject TargetMesh) { return default; }
	public int GetNumConnectedComponents(UObject TargetMesh) { return default; }
	public int GetNumTriangleIDs(UObject TargetMesh) { return default; }
	public bool GetHasTriangleIDGaps(UObject TargetMesh) { return default; }
	public bool IsValidTriangleID(UObject TargetMesh,int TriangleID) { return default; }
	public UObject GetAllTriangleIDs(UObject TargetMesh,FGeometryScriptIndexList TriangleIDList,bool bHasTriangleIDGaps) { return default; }
	public FIntVector GetTriangleIndices(UObject TargetMesh,int TriangleID,bool bIsValidTriangle) { return default; }
	public UObject GetAllTriangleIndices(UObject TargetMesh,FGeometryScriptTriangleList TriangleList,bool bSkipGaps,bool bHasTriangleIDGaps) { return default; }
	public void GetTrianglePositions(UObject TargetMesh,int TriangleID,bool bIsValidTriangle,FVector Vertex1,FVector Vertex2,FVector Vertex3) {}
	public UObject GetInterpolatedTrianglePosition(UObject TargetMesh,int TriangleID,FVector BarycentricCoords,bool bIsValidTriangle,FVector InterpolatedPosition) { return default; }
	public FVector GetTriangleFaceNormal(UObject TargetMesh,int TriangleID,bool bIsValidTriangle) { return default; }
	public UObject ComputeTriangleBarycentricCoords(UObject TargetMesh,int TriangleID,bool bIsValidTriangle,FVector Point,FVector Vertex1,FVector Vertex2,FVector Vertex3,FVector BarycentricCoords) { return default; }
	public int GetVertexCount(UObject TargetMesh) { return default; }
	public int GetNumVertexIDs(UObject TargetMesh) { return default; }
	public bool GetHasVertexIDGaps(UObject TargetMesh) { return default; }
	public bool IsValidVertexID(UObject TargetMesh,int VertexID) { return default; }
	public UObject GetAllVertexIDs(UObject TargetMesh,FGeometryScriptIndexList VertexIDList,bool bHasVertexIDGaps) { return default; }
	public FVector GetVertexPosition(UObject TargetMesh,int VertexID,bool bIsValidVertex) { return default; }
	public UObject GetAllVertexPositions(UObject TargetMesh,FGeometryScriptVectorList PositionList,bool bSkipGaps,bool bHasVertexIDGaps) { return default; }
	public int GetNumUVSets(UObject TargetMesh) { return default; }
	public FBox2D GetUVSetBoundingBox(UObject TargetMesh,int UVSetIndex,bool bIsValidUVSet,bool bUVSetIsEmpty) { return default; }
	public void GetTriangleUVs(UObject TargetMesh,int UVSetIndex,int TriangleID,FVector2D UV1,FVector2D UV2,FVector2D UV3,bool bHaveValidUVs) {}
	public UObject GetInterpolatedTriangleUV(UObject TargetMesh,int UVSetIndex,int TriangleID,FVector BarycentricCoords,bool bTriHasValidUVs,FVector2D InterpolatedUV) { return default; }
	public bool GetHasTriangleNormals(UObject TargetMesh) { return default; }
	public UObject GetTriangleNormals(UObject TargetMesh,int TriangleID,FVector Normal1,FVector Normal2,FVector Normal3,bool bTriHasValidNormals) { return default; }
	public UObject GetInterpolatedTriangleNormal(UObject TargetMesh,int TriangleID,FVector BarycentricCoords,bool bTriHasValidNormals,FVector InterpolatedNormal) { return default; }
	public UObject GetTriangleNormalTangents(UObject TargetMesh,int TriangleID,bool bTriHasValidElements,FGeometryScriptTriangle Normals,FGeometryScriptTriangle Tangents,FGeometryScriptTriangle BiTangents) { return default; }
	public UObject GetInterpolatedTriangleNormalTangents(UObject TargetMesh,int TriangleID,FVector BarycentricCoords,bool bTriHasValidElements,FVector InterpolatedNormal,FVector InterpolatedTangent,FVector InterpolatedBiTangent) { return default; }
	public bool GetHasVertexColors(UObject TargetMesh) { return default; }
	public UObject GetTriangleVertexColors(UObject TargetMesh,int TriangleID,FLinearColor Color1,FLinearColor Color2,FLinearColor Color3,bool bTriHasValidVertexColors) { return default; }
	public UObject GetInterpolatedTriangleVertexColor(UObject TargetMesh,int TriangleID,FVector BarycentricCoords,FLinearColor DefaultColor,bool bTriHasValidVertexColors,FLinearColor InterpolatedColor) { return default; }
	public bool GetHasMaterialIDs(UObject TargetMesh) { return default; }
	public bool GetHasPolygroups(UObject TargetMesh) { return default; }
	public int GetNumExtendedPolygroupLayers(UObject TargetMesh) { return default; }
}
