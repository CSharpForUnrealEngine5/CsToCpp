namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshUVFunctions.h")]
public partial class UGeometryScriptLibrary_MeshUVFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Set the number of UV Channels on the Target Mesh. If not already enabled, this will enable the mesh attributes.</summary>
	public static UDynamicMesh SetNumUVSets(UDynamicMesh TargetMesh,int NumUVSets,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Copy the data in one UV Channel to another UV Channel on the same Target Mesh.</summary>
	public static UDynamicMesh CopyUVSet(UDynamicMesh TargetMesh,int FromUVSet,int ToUVSet,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Sets the UVs of a mesh triangle in the given UV Channel.</summary>
	public static UDynamicMesh SetMeshTriangleUVs(UDynamicMesh TargetMesh,int UVSetIndex,int TriangleID,FGeometryScriptUVTriangle UVs,bool bIsValidTriangle,bool bDeferChangeNotifications/*=false*/) { return default; }
	///<summary>Update all selected UV values in the specified UV Channel by adding the Translation value to each.</summary>
	public static UDynamicMesh TranslateMeshUVs(UDynamicMesh TargetMesh,int UVSetIndex,FVector2D Translation,FGeometryScriptMeshSelection Selection,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Update all selected UV values in the specified UV Channel by Scale, mathematically the new value is given by (UV - ScaleOrigin) * Scale + ScaleOrigin</summary>
	public static UDynamicMesh ScaleMeshUVs(UDynamicMesh TargetMesh,int UVSetIndex,FVector2D Scale,FVector2D ScaleOrigin,FGeometryScriptMeshSelection Selection,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Update all the selected UV values in the specified UV Channel by a rotation of Rotation Angle (in degrees) relative to the Rotation Origin.</summary>
	public static UDynamicMesh RotateMeshUVs(UDynamicMesh TargetMesh,int UVSetIndex,float RotationAngle,FVector2D RotationOrigin,FGeometryScriptMeshSelection Selection,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Scale of PlaneTransform defines world-space dimension that maps to 1 UV dimension</summary>
	public static UDynamicMesh SetMeshUVsFromPlanarProjection(UDynamicMesh TargetMesh,int UVSetIndex,FTransform PlaneTransform,FGeometryScriptMeshSelection Selection,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Using Box Projection, update the UVs in the UV Channel for an entire mesh or a subset defined by a non-empty Selection.</summary>
	public static UDynamicMesh SetMeshUVsFromBoxProjection(UDynamicMesh TargetMesh,int UVSetIndex,FTransform BoxTransform,FGeometryScriptMeshSelection Selection,int MinIslandTriCount/*=2*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Using Cylinder Projection, update the UVs in the UV Channel for an entire mesh or a subset defined by a non-empty Selection.</summary>
	public static UDynamicMesh SetMeshUVsFromCylinderProjection(UDynamicMesh TargetMesh,int UVSetIndex,FTransform CylinderTransform,FGeometryScriptMeshSelection Selection,float SplitAngle/*=45.0f*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Recomputes UVs in the UV Channel for a Mesh based on different types of well-defined UV islands, such as existing UV islands, PolyGroups,</summary>
	public static UDynamicMesh RecomputeMeshUVs(UDynamicMesh TargetMesh,int UVSetIndex,FGeometryScriptRecomputeUVsOptions Options,FGeometryScriptMeshSelection Selection,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Packs the existing UV islands in the specified UV Channel into standard UV space based on the Repack Options.</summary>
	public static UDynamicMesh RepackMeshUVs(UDynamicMesh TargetMesh,int UVSetIndex,FGeometryScriptRepackUVsOptions RepackOptions,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Computes new UVs for the specified UV Channel using PatchBuilder method in the Options, and optionally packs.</summary>
	public static UDynamicMesh AutoGeneratePatchBuilderMeshUVs(UDynamicMesh TargetMesh,int UVSetIndex,FGeometryScriptPatchBuilderOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Computes new UVs for the specified UV Channel using XAtlas, and optionally packs.</summary>
	public static UDynamicMesh AutoGenerateXAtlasMeshUVs(UDynamicMesh TargetMesh,int UVSetIndex,FGeometryScriptXAtlasOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Compute information about dimensions and areas for a UV Set of a Mesh, with an optional Mesh Selection</summary>
	public static UDynamicMesh GetMeshUVSizeInfo(UDynamicMesh TargetMesh,int UVSetIndex,FGeometryScriptMeshSelection Selection,double MeshArea,double UVArea,FBox MeshBounds,FBox2D UVBounds,bool bIsValidUVSet,bool bFoundUnsetUVs,bool bOnlyIncludeValidUVTris/*=true*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Get a list of single vertex UVs for each mesh vertex in the TargetMesh, derived from the specified UV Channel.</summary>
	public static UDynamicMesh GetMeshPerVertexUVs(UDynamicMesh TargetMesh,int UVSetIndex,FGeometryScriptUVList UVList,bool bIsValidUVSet,bool bHasVertexIDGaps,bool bHasSplitUVs,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Copy the 2D UVs from the given UV Channel in CopyFromMesh to the 3D vertex positions in CopyToUVMesh,</summary>
	public static UDynamicMesh CopyMeshUVLayerToMesh(UDynamicMesh CopyFromMesh,int UVSetIndex,UDynamicMesh CopyToUVMesh,UDynamicMesh CopyToUVMeshOut,bool bInvalidTopology,bool bIsValidUVSet,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Transfer the 3D vertex positions and triangles of CopyFromUVMesh to the given UV Channel identified by ToUVChannel of CopyToMesh.</summary>
	public static UDynamicMesh CopyMeshToMeshUVLayer(UDynamicMesh CopyFromUVMesh,int ToUVSetIndex,UDynamicMesh CopyToMesh,UDynamicMesh CopyToMeshOut,bool bFoundTopologyErrors,bool bIsValidUVSet,bool bOnlyUVPositions/*=true*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Compute local UV parameterization on TargetMesh vertices around the given CenterPoint / Triangle. This method</summary>
	public static UDynamicMesh ComputeMeshLocalUVParam(UDynamicMesh TargetMesh,FVector CenterPoint,int CenterPointTriangleID,TArray<int> VertexIDs,TArray<FVector2D> VertexUVs,double Radius/*=1*/,bool bUseInterpolatedNormal/*=false*/,FVector TangentYDirection/*=new FVector(0,0,0)*/,double UVRotationDeg/*=0.0*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
