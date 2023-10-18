namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshRepairFunctions.h")]
public partial class UGeometryScriptLibrary_MeshRepairFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Compacts the mesh&#39;s vertices and triangles to remove any &quot;holes&quot; in the Vertex ID or Triangle ID lists.</summary>
	public static UDynamicMesh CompactMesh(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Attempts to resolve T-Junctions in the mesh by addition of vertices and welding.</summary>
	public static UDynamicMesh ResolveMeshTJunctions(UDynamicMesh TargetMesh,FGeometryScriptResolveTJunctionOptions ResolveOptions,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Welds any open boundary edges of the mesh together if possible in order to remove &quot;cracks.&quot;</summary>
	public static UDynamicMesh WeldMeshEdges(UDynamicMesh TargetMesh,FGeometryScriptWeldEdgesOptions WeldOptions,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Tries to fill all open boundary loops (such as holes in the geometry surface) of a mesh.</summary>
	public static UDynamicMesh FillAllMeshHoles(UDynamicMesh TargetMesh,FGeometryScriptFillHolesOptions FillOptions,int NumFilledHoles,int NumFailedHoleFills,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>* Removes connected components of the mesh that have a volume, area, or triangle count below a threshold as specified by the Options.</summary>
	public static UDynamicMesh RemoveSmallComponents(UDynamicMesh TargetMesh,FGeometryScriptRemoveSmallComponentOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Removes any triangles in the mesh that are not visible from the exterior view, under various definitions of &quot;visible&quot; and &quot;outside&quot;</summary>
	public static UDynamicMesh RemoveHiddenTriangles(UDynamicMesh TargetMesh,FGeometryScriptRemoveHiddenTrianglesOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Splits Bowties in the mesh and/or the attributes.  A Bowtie is formed when a single vertex is connected to more than two boundary edges,</summary>
	public static UDynamicMesh SplitMeshBowties(UDynamicMesh TargetMesh,bool bMeshBowties/*=true*/,bool bAttributeBowties/*=true*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Removes triangles that have area or edge length below specified amounts depending on the Options requested.</summary>
	public static UDynamicMesh RepairMeshDegenerateGeometry(UDynamicMesh TargetMesh,FGeometryScriptDegenerateTriangleOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
