namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSpatialFunctions.h")]
public partial class UGeometryScriptLibrary_MeshSpatial : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Reset the Bounding Volume Hierarchy (BVH) by clearing all the internal data.</summary>
	public static void ResetBVH(FGeometryScriptDynamicMeshBVH ResetBVH) {}
	///<summary>Builds a Bounding Volume Hierarchy (BVH) object for a mesh that can be used with multiple spatial queries.</summary>
	public static UDynamicMesh BuildBVHForMesh(UDynamicMesh TargetMesh,FGeometryScriptDynamicMeshBVH OutputBVH,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Checks if the provided Bounding Volume Hierarchy (BVH) can still be used with the Mesh — it generally returns false if the mesh has been changed.</summary>
	public static UDynamicMesh IsBVHValidForMesh(UDynamicMesh TargetMesh,FGeometryScriptDynamicMeshBVH TestBVH,bool bIsValid,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Rebuilds the Bounding Volume Hierarchy (BVH) for the mesh in-place, which can reduce memory allocations, compared to building a new BVH.</summary>
	public static UDynamicMesh RebuildBVHForMesh(UDynamicMesh TargetMesh,FGeometryScriptDynamicMeshBVH UpdateBVH,bool bOnlyIfInvalid/*=true*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Finds the nearest point (Nearest Result) on the Target Mesh to a given 3D point (Query Point) by using the Query BVH.</summary>
	public static UDynamicMesh FindNearestPointOnMesh(UDynamicMesh TargetMesh,FGeometryScriptDynamicMeshBVH QueryBVH,FVector QueryPoint,FGeometryScriptSpatialQueryOptions Options,FGeometryScriptTrianglePoint NearestResult,EGeometryScriptSearchOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Finds the nearest intersection of a 3D ray with the mesh by using the Query BVH.</summary>
	public static UDynamicMesh FindNearestRayIntersectionWithMesh(UDynamicMesh TargetMesh,FGeometryScriptDynamicMeshBVH QueryBVH,FVector RayOrigin,FVector RayDirection,FGeometryScriptSpatialQueryOptions Options,FGeometryScriptRayHitResult HitResult,EGeometryScriptSearchOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Tests if a point is inside the mesh using the Fast Winding Number query and data stored in the BVH.</summary>
	public static UDynamicMesh IsPointInsideMesh(UDynamicMesh TargetMesh,FGeometryScriptDynamicMeshBVH QueryBVH,FVector QueryPoint,FGeometryScriptSpatialQueryOptions Options,bool bIsInside,EGeometryScriptContainmentOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Create Mesh Selection of mesh elements in TargetMesh contained by QueryBox, using QueryBVH to accellerate the computation.</summary>
	public static UDynamicMesh SelectMeshElementsInBoxWithBVH(UDynamicMesh TargetMesh,FGeometryScriptDynamicMeshBVH QueryBVH,FBox QueryBox,FGeometryScriptSpatialQueryOptions Options,FGeometryScriptMeshSelection Selection,EGeometryScriptMeshSelectionType SelectionType/*=EGeometryScriptMeshSelectionType.Vertices*/,int MinNumTrianglePoints/*=3*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
