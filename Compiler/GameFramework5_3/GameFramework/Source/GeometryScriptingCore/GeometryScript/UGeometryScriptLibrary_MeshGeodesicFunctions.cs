namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshGeodesicFunctions.h")]
public partial class UGeometryScriptLibrary_MeshGeodesicFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Computes a vertex list that represents the shortest path constrained to travel along mesh triangle edges between the prescribed start and end vertex.</summary>
	public static UDynamicMesh GetShortestVertexPath(UDynamicMesh TargetMesh,int StartVertexID,int EndVertexID,FGeometryScriptIndexList VertexIDList,bool bFoundErrors,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Computes a PolyPath that represents the shortest mesh surface path between two prescribed points on the provided mesh.</summary>
	public static UDynamicMesh GetShortestSurfacePath(UDynamicMesh TargetMesh,int StartTriangleID,FVector StartBaryCoords,int EndTriangleID,FVector EndBaryCoords,FGeometryScriptPolyPath ShortestPath,bool bFoundErrors,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Computes a PolyPath that represents a &quot;straight&quot; surface path starting at the prescribed point on the mesh, and continuing</summary>
	public static UDynamicMesh CreateSurfacePath(UDynamicMesh TargetMesh,FVector Direction,int StartTriangleID,FVector StartBaryCoords,float MaxPathLength,FGeometryScriptPolyPath SurfacePath,bool bFoundErrors,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
