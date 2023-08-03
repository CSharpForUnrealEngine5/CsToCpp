#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSpatialFunctions.h")]
public partial class UGeometryScriptLibrary_MeshSpatial : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>ResetBVH</summary>
	public static void ResetBVH(FGeometryScriptDynamicMeshBVH ResetBVH) {}
	///<summary>BuildBVHForMesh</summary>
	public static UDynamicMesh BuildBVHForMesh(UDynamicMesh TargetMesh,FGeometryScriptDynamicMeshBVH OutputBVH,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>IsBVHValidForMesh</summary>
	public static UDynamicMesh IsBVHValidForMesh(UDynamicMesh TargetMesh,FGeometryScriptDynamicMeshBVH TestBVH,bool bIsValid,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>RebuildBVHForMesh</summary>
	public static UDynamicMesh RebuildBVHForMesh(UDynamicMesh TargetMesh,FGeometryScriptDynamicMeshBVH UpdateBVH,bool bOnlyIfInvalid/*=true*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>FindNearestPointOnMesh</summary>
	public static UDynamicMesh FindNearestPointOnMesh(UDynamicMesh TargetMesh,FGeometryScriptDynamicMeshBVH QueryBVH,FVector QueryPoint,FGeometryScriptSpatialQueryOptions Options,FGeometryScriptTrianglePoint NearestResult,EGeometryScriptSearchOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>FindNearestRayIntersectionWithMesh</summary>
	public static UDynamicMesh FindNearestRayIntersectionWithMesh(UDynamicMesh TargetMesh,FGeometryScriptDynamicMeshBVH QueryBVH,FVector RayOrigin,FVector RayDirection,FGeometryScriptSpatialQueryOptions Options,FGeometryScriptRayHitResult HitResult,EGeometryScriptSearchOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>IsPointInsideMesh</summary>
	public static UDynamicMesh IsPointInsideMesh(UDynamicMesh TargetMesh,FGeometryScriptDynamicMeshBVH QueryBVH,FVector QueryPoint,FGeometryScriptSpatialQueryOptions Options,bool bIsInside,EGeometryScriptContainmentOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
