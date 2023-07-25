#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshRepairFunctions.h")]
public partial class UGeometryScriptLibrary_MeshRepairFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshRepairFunctions
	public UObject CompactMesh(UObject TargetMesh,UObject Debug/*=nullptr*/) { return default; }
	public UObject ResolveMeshTJunctions(UObject TargetMesh,FGeometryScriptResolveTJunctionOptions ResolveOptions,UObject Debug/*=nullptr*/) { return default; }
	public UObject WeldMeshEdges(UObject TargetMesh,FGeometryScriptWeldEdgesOptions WeldOptions,UObject Debug/*=nullptr*/) { return default; }
	public UObject FillAllMeshHoles(UObject TargetMesh,FGeometryScriptFillHolesOptions FillOptions,int NumFilledHoles,int NumFailedHoleFills,UObject Debug/*=nullptr*/) { return default; }
	public UObject RemoveSmallComponents(UObject TargetMesh,FGeometryScriptRemoveSmallComponentOptions Options,UObject Debug/*=nullptr*/) { return default; }
	public UObject RemoveHiddenTriangles(UObject TargetMesh,FGeometryScriptRemoveHiddenTrianglesOptions Options,UObject Debug/*=nullptr*/) { return default; }
	public UObject SplitMeshBowties(UObject TargetMesh,bool bMeshBowties/*=true*/,bool bAttributeBowties/*=true*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject RepairMeshDegenerateGeometry(UObject TargetMesh,FGeometryScriptDegenerateTriangleOptions Options,UObject Debug/*=nullptr*/) { return default; }
}
