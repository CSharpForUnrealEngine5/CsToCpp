namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshNormalsFunctions.h")]
public partial class UGeometryScriptLibrary_MeshNormalsFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Flip/Invert the normal vectors of TargetMesh by multiplying them by -1, as well as reversing the mesh triangle orientations, ie triangle (a,b,c) becomes (b,a,c)</summary>
	public static UDynamicMesh FlipNormals(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Attempt to repair inconsistent normals in TargetMesh. Currently this is done in two passes. In the first pass, triangles with</summary>
	public static UDynamicMesh AutoRepairNormals(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Recompute the normals of TargetMesh by averaging the triangle/face normals around each vertex, using combined area and angle weighting.</summary>
	public static UDynamicMesh SetPerVertexNormals(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Recompute the normals of TargetMesh by setting the normals of each triangle vertex to the triangle/face normal.</summary>
	public static UDynamicMesh SetPerFaceNormals(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Recompute the normals of TargetMesh using the given CalculateOptions. This method will preserve any existing hard</summary>
	public static UDynamicMesh RecomputeNormals(UDynamicMesh TargetMesh,FGeometryScriptCalculateNormalsOptions CalculateOptions,bool bDeferChangeNotifications/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Recompute the normals of TargetMesh on all the triangles/vertices of the given Selection using the given CalculateOptions.</summary>
	public static UDynamicMesh RecomputeNormalsForMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptCalculateNormalsOptions CalculateOptions,bool bDeferChangeNotifications/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Recompute hard edges / split-normals for TargetMesh based on the provided SplitOptions, and then</summary>
	public static UDynamicMesh ComputeSplitNormals(UDynamicMesh TargetMesh,FGeometryScriptSplitNormalsOptions SplitOptions,FGeometryScriptCalculateNormalsOptions CalculateOptions,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Set the triangle-vertex normals for the given TriangleID on the TargetMesh. This will</summary>
	public static UDynamicMesh SetMeshTriangleNormals(UDynamicMesh TargetMesh,int TriangleID,FGeometryScriptTriangle Normals,bool bIsValidTriangle,bool bDeferChangeNotifications/*=false*/) { return default; }
	///<summary>Set all normals in the TargetMesh Normals Overlay to the specified per-vertex normals</summary>
	public static UDynamicMesh SetMeshPerVertexNormals(UDynamicMesh TargetMesh,FGeometryScriptVectorList VertexNormalList,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Get a list of single normal vectors for each mesh vertex in the TargetMesh, derived from the Normals Overlay.</summary>
	public static UDynamicMesh GetMeshPerVertexNormals(UDynamicMesh TargetMesh,FGeometryScriptVectorList NormalList,bool bIsValidNormalSet,bool bHasVertexIDGaps,bool bAverageSplitVertexValues/*=true*/) { return default; }
	///<summary>Check if the TargetMesh has a Tangents Attribute Layer enabled</summary>
	public static UDynamicMesh GetMeshHasTangents(UDynamicMesh TargetMesh,bool bHasTangents,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Remove any existing Tangents Attribute Layer from the TargetMesh</summary>
	public static UDynamicMesh DiscardTangents(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Recompute Tangents for the TargetMesh, using the method and settings specified by FGeometryScriptTangentsOptions</summary>
	public static UDynamicMesh ComputeTangents(UDynamicMesh TargetMesh,FGeometryScriptTangentsOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Set all tangents in the TargetMesh Tangents Overlays to the specified per-vertex tangents</summary>
	public static UDynamicMesh SetMeshPerVertexTangents(UDynamicMesh TargetMesh,FGeometryScriptVectorList TangentXList,FGeometryScriptVectorList TangentYList,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Get a list of single tangent vectors for each mesh vertex in the TargetMesh, derived from the Tangents Overlays.</summary>
	public static UDynamicMesh GetMeshPerVertexTangents(UDynamicMesh TargetMesh,FGeometryScriptVectorList TangentXList,FGeometryScriptVectorList TangentYList,bool bIsValidTangentSet,bool bHasVertexIDGaps,bool bAverageSplitVertexValues/*=true*/) { return default; }
	///<summary>Update the Normals and/or Tangents at VertexID of TargetMesh. Note that the specified vertex may have &quot;split normals&quot;</summary>
	public static UDynamicMesh UpdateVertexNormal(UDynamicMesh TargetMesh,int VertexID,bool bUpdateNormal,FVector NewNormal,bool bUpdateTangents,FVector NewTangentX,FVector NewTangentY,bool bIsValidVertex,bool bMergeSplitValues,bool bDeferChangeNotifications/*=false*/) { return default; }
}
