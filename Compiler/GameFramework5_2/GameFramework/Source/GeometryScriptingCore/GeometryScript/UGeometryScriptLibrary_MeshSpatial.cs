#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSpatialFunctions.h")]
public partial class UGeometryScriptLibrary_MeshSpatial : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshSpatial
	public static void ResetBVH(FGeometryScriptDynamicMeshBVH ResetBVH) {}
	public static UDynamicMesh BuildBVHForMesh(UDynamicMesh TargetMesh,FGeometryScriptDynamicMeshBVH OutputBVH,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh IsBVHValidForMesh(UDynamicMesh TargetMesh,FGeometryScriptDynamicMeshBVH TestBVH,bool bIsValid,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh RebuildBVHForMesh(UDynamicMesh TargetMesh,FGeometryScriptDynamicMeshBVH UpdateBVH,bool bOnlyIfInvalid/*=true*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh FindNearestPointOnMesh(UDynamicMesh TargetMesh,FGeometryScriptDynamicMeshBVH QueryBVH,FVector QueryPoint,FGeometryScriptSpatialQueryOptions Options,FGeometryScriptTrianglePoint NearestResult,EGeometryScriptSearchOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh FindNearestRayIntersectionWithMesh(UDynamicMesh TargetMesh,FGeometryScriptDynamicMeshBVH QueryBVH,FVector RayOrigin,FVector RayDirection,FGeometryScriptSpatialQueryOptions Options,FGeometryScriptRayHitResult HitResult,EGeometryScriptSearchOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh IsPointInsideMesh(UDynamicMesh TargetMesh,FGeometryScriptDynamicMeshBVH QueryBVH,FVector QueryPoint,FGeometryScriptSpatialQueryOptions Options,bool bIsInside,EGeometryScriptContainmentOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
