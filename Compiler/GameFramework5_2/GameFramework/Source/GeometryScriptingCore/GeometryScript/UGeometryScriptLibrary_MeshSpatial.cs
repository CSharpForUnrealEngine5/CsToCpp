#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSpatialFunctions.h")]
public partial class UGeometryScriptLibrary_MeshSpatial : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshSpatial
	public void ResetBVH(FGeometryScriptDynamicMeshBVH ResetBVH) {}
	public UObject BuildBVHForMesh(UObject TargetMesh,FGeometryScriptDynamicMeshBVH OutputBVH,UObject Debug/*=nullptr*/) { return default; }
	public UObject IsBVHValidForMesh(UObject TargetMesh,FGeometryScriptDynamicMeshBVH TestBVH,bool bIsValid,UObject Debug/*=nullptr*/) { return default; }
	public UObject RebuildBVHForMesh(UObject TargetMesh,FGeometryScriptDynamicMeshBVH UpdateBVH,bool bOnlyIfInvalid/*=true*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject FindNearestPointOnMesh(UObject TargetMesh,FGeometryScriptDynamicMeshBVH QueryBVH,FVector QueryPoint,FGeometryScriptSpatialQueryOptions Options,FGeometryScriptTrianglePoint NearestResult,EGeometryScriptSearchOutcomePins Outcome,UObject Debug/*=nullptr*/) { return default; }
	public UObject FindNearestRayIntersectionWithMesh(UObject TargetMesh,FGeometryScriptDynamicMeshBVH QueryBVH,FVector RayOrigin,FVector RayDirection,FGeometryScriptSpatialQueryOptions Options,FGeometryScriptRayHitResult HitResult,EGeometryScriptSearchOutcomePins Outcome,UObject Debug/*=nullptr*/) { return default; }
	public UObject IsPointInsideMesh(UObject TargetMesh,FGeometryScriptDynamicMeshBVH QueryBVH,FVector QueryPoint,FGeometryScriptSpatialQueryOptions Options,bool bIsInside,EGeometryScriptContainmentOutcomePins Outcome,UObject Debug/*=nullptr*/) { return default; }
}
