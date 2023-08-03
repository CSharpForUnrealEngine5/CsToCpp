#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshRepairFunctions.h")]
public partial class UGeometryScriptLibrary_MeshRepairFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>CompactMesh</summary>
	public static UDynamicMesh CompactMesh(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ResolveMeshTJunctions</summary>
	public static UDynamicMesh ResolveMeshTJunctions(UDynamicMesh TargetMesh,FGeometryScriptResolveTJunctionOptions ResolveOptions,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>WeldMeshEdges</summary>
	public static UDynamicMesh WeldMeshEdges(UDynamicMesh TargetMesh,FGeometryScriptWeldEdgesOptions WeldOptions,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>FillAllMeshHoles</summary>
	public static UDynamicMesh FillAllMeshHoles(UDynamicMesh TargetMesh,FGeometryScriptFillHolesOptions FillOptions,int NumFilledHoles,int NumFailedHoleFills,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>RemoveSmallComponents</summary>
	public static UDynamicMesh RemoveSmallComponents(UDynamicMesh TargetMesh,FGeometryScriptRemoveSmallComponentOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>RemoveHiddenTriangles</summary>
	public static UDynamicMesh RemoveHiddenTriangles(UDynamicMesh TargetMesh,FGeometryScriptRemoveHiddenTrianglesOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>SplitMeshBowties</summary>
	public static UDynamicMesh SplitMeshBowties(UDynamicMesh TargetMesh,bool bMeshBowties/*=true*/,bool bAttributeBowties/*=true*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>RepairMeshDegenerateGeometry</summary>
	public static UDynamicMesh RepairMeshDegenerateGeometry(UDynamicMesh TargetMesh,FGeometryScriptDegenerateTriangleOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
