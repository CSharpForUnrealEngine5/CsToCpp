#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshUVFunctions.h")]
public partial class UGeometryScriptLibrary_MeshUVFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshUVFunctions
	public static UDynamicMesh SetNumUVSets(UDynamicMesh TargetMesh,int NumUVSets,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh CopyUVSet(UDynamicMesh TargetMesh,int FromUVSet,int ToUVSet,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh SetMeshTriangleUVs(UDynamicMesh TargetMesh,int UVSetIndex,int TriangleID,FGeometryScriptUVTriangle UVs,bool bIsValidTriangle,bool bDeferChangeNotifications/*=false*/) { return default; }
	public static UDynamicMesh TranslateMeshUVs(UDynamicMesh TargetMesh,int UVSetIndex,FVector2D Translation,FGeometryScriptMeshSelection Selection,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ScaleMeshUVs(UDynamicMesh TargetMesh,int UVSetIndex,FVector2D Scale,FVector2D ScaleOrigin,FGeometryScriptMeshSelection Selection,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh RotateMeshUVs(UDynamicMesh TargetMesh,int UVSetIndex,float RotationAngle,FVector2D RotationOrigin,FGeometryScriptMeshSelection Selection,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh SetMeshUVsFromPlanarProjection(UDynamicMesh TargetMesh,int UVSetIndex,FTransform PlaneTransform,FGeometryScriptMeshSelection Selection,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh SetMeshUVsFromBoxProjection(UDynamicMesh TargetMesh,int UVSetIndex,FTransform BoxTransform,FGeometryScriptMeshSelection Selection,int MinIslandTriCount/*=2*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh SetMeshUVsFromCylinderProjection(UDynamicMesh TargetMesh,int UVSetIndex,FTransform CylinderTransform,FGeometryScriptMeshSelection Selection,float SplitAngle/*=45.0f*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh RecomputeMeshUVs(UDynamicMesh TargetMesh,int UVSetIndex,FGeometryScriptRecomputeUVsOptions Options,FGeometryScriptMeshSelection Selection,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh RepackMeshUVs(UDynamicMesh TargetMesh,int UVSetIndex,FGeometryScriptRepackUVsOptions RepackOptions,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh AutoGeneratePatchBuilderMeshUVs(UDynamicMesh TargetMesh,int UVSetIndex,FGeometryScriptPatchBuilderOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh AutoGenerateXAtlasMeshUVs(UDynamicMesh TargetMesh,int UVSetIndex,FGeometryScriptXAtlasOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh GetMeshUVSizeInfo(UDynamicMesh TargetMesh,int UVSetIndex,FGeometryScriptMeshSelection Selection,double MeshArea,double UVArea,FBox MeshBounds,FBox2D UVBounds,bool bIsValidUVSet,bool bFoundUnsetUVs,bool bOnlyIncludeValidUVTris/*=true*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh GetMeshPerVertexUVs(UDynamicMesh TargetMesh,int UVSetIndex,FGeometryScriptUVList UVList,bool bIsValidUVSet,bool bHasVertexIDGaps,bool bHasSplitUVs,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh CopyMeshUVLayerToMesh(UDynamicMesh CopyFromMesh,int UVSetIndex,UDynamicMesh CopyToUVMesh,UDynamicMesh CopyToUVMeshOut,bool bInvalidTopology,bool bIsValidUVSet,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh CopyMeshToMeshUVLayer(UDynamicMesh CopyFromUVMesh,int ToUVSetIndex,UDynamicMesh CopyToMesh,UDynamicMesh CopyToMeshOut,bool bFoundTopologyErrors,bool bIsValidUVSet,bool bOnlyUVPositions/*=true*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
