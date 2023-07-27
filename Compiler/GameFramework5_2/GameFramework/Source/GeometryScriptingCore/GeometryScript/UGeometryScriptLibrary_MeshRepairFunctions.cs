#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshRepairFunctions.h")]
public partial class UGeometryScriptLibrary_MeshRepairFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshRepairFunctions
	public static UDynamicMesh CompactMesh(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ResolveMeshTJunctions(UDynamicMesh TargetMesh,FGeometryScriptResolveTJunctionOptions ResolveOptions,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh WeldMeshEdges(UDynamicMesh TargetMesh,FGeometryScriptWeldEdgesOptions WeldOptions,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh FillAllMeshHoles(UDynamicMesh TargetMesh,FGeometryScriptFillHolesOptions FillOptions,int NumFilledHoles,int NumFailedHoleFills,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh RemoveSmallComponents(UDynamicMesh TargetMesh,FGeometryScriptRemoveSmallComponentOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh RemoveHiddenTriangles(UDynamicMesh TargetMesh,FGeometryScriptRemoveHiddenTrianglesOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh SplitMeshBowties(UDynamicMesh TargetMesh,bool bMeshBowties/*=true*/,bool bAttributeBowties/*=true*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh RepairMeshDegenerateGeometry(UDynamicMesh TargetMesh,FGeometryScriptDegenerateTriangleOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
