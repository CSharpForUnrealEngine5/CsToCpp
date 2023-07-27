#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshNormalsFunctions.h")]
public partial class UGeometryScriptLibrary_MeshNormalsFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshNormalsFunctions
	public static UDynamicMesh FlipNormals(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh AutoRepairNormals(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh SetPerVertexNormals(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh SetPerFaceNormals(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh RecomputeNormals(UDynamicMesh TargetMesh,FGeometryScriptCalculateNormalsOptions CalculateOptions,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ComputeSplitNormals(UDynamicMesh TargetMesh,FGeometryScriptSplitNormalsOptions SplitOptions,FGeometryScriptCalculateNormalsOptions CalculateOptions,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh SetMeshTriangleNormals(UDynamicMesh TargetMesh,int TriangleID,FGeometryScriptTriangle Normals,bool bIsValidTriangle,bool bDeferChangeNotifications/*=false*/) { return default; }
	public static UDynamicMesh SetMeshPerVertexNormals(UDynamicMesh TargetMesh,FGeometryScriptVectorList VertexNormalList,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh GetMeshPerVertexNormals(UDynamicMesh TargetMesh,FGeometryScriptVectorList NormalList,bool bIsValidNormalSet,bool bHasVertexIDGaps,bool bAverageSplitVertexValues/*=true*/) { return default; }
	public static UDynamicMesh GetMeshHasTangents(UDynamicMesh TargetMesh,bool bHasTangents,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh DiscardTangents(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ComputeTangents(UDynamicMesh TargetMesh,FGeometryScriptTangentsOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh SetMeshPerVertexTangents(UDynamicMesh TargetMesh,FGeometryScriptVectorList TangentXList,FGeometryScriptVectorList TangentYList,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh GetMeshPerVertexTangents(UDynamicMesh TargetMesh,FGeometryScriptVectorList TangentXList,FGeometryScriptVectorList TangentYList,bool bIsValidTangentSet,bool bHasVertexIDGaps,bool bAverageSplitVertexValues/*=true*/) { return default; }
	public static UDynamicMesh UpdateVertexNormal(UDynamicMesh TargetMesh,int VertexID,bool bUpdateNormal,FVector NewNormal,bool bUpdateTangents,FVector NewTangentX,FVector NewTangentY,bool bIsValidVertex,bool bMergeSplitValues,bool bDeferChangeNotifications/*=false*/) { return default; }
}
