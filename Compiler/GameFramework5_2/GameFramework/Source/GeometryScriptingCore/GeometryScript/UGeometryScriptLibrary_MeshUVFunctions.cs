#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshUVFunctions.h")]
public partial class UGeometryScriptLibrary_MeshUVFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshUVFunctions
	public UObject SetNumUVSets(UObject TargetMesh,int NumUVSets,UObject Debug/*=nullptr*/) { return default; }
	public UObject CopyUVSet(UObject TargetMesh,int FromUVSet,int ToUVSet,UObject Debug/*=nullptr*/) { return default; }
	public UObject SetMeshTriangleUVs(UObject TargetMesh,int UVSetIndex,int TriangleID,FGeometryScriptUVTriangle UVs,bool bIsValidTriangle,bool bDeferChangeNotifications/*=false*/) { return default; }
	public UObject TranslateMeshUVs(UObject TargetMesh,int UVSetIndex,FVector2D Translation,FGeometryScriptMeshSelection Selection,UObject Debug/*=nullptr*/) { return default; }
	public UObject ScaleMeshUVs(UObject TargetMesh,int UVSetIndex,FVector2D Scale,FVector2D ScaleOrigin,FGeometryScriptMeshSelection Selection,UObject Debug/*=nullptr*/) { return default; }
	public UObject RotateMeshUVs(UObject TargetMesh,int UVSetIndex,float RotationAngle,FVector2D RotationOrigin,FGeometryScriptMeshSelection Selection,UObject Debug/*=nullptr*/) { return default; }
	public UObject SetMeshUVsFromPlanarProjection(UObject TargetMesh,int UVSetIndex,FTransform PlaneTransform,FGeometryScriptMeshSelection Selection,UObject Debug/*=nullptr*/) { return default; }
	public UObject SetMeshUVsFromBoxProjection(UObject TargetMesh,int UVSetIndex,FTransform BoxTransform,FGeometryScriptMeshSelection Selection,int MinIslandTriCount/*=2*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject SetMeshUVsFromCylinderProjection(UObject TargetMesh,int UVSetIndex,FTransform CylinderTransform,FGeometryScriptMeshSelection Selection,float SplitAngle/*=45.0f*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject RecomputeMeshUVs(UObject TargetMesh,int UVSetIndex,FGeometryScriptRecomputeUVsOptions Options,FGeometryScriptMeshSelection Selection,UObject Debug/*=nullptr*/) { return default; }
	public UObject RepackMeshUVs(UObject TargetMesh,int UVSetIndex,FGeometryScriptRepackUVsOptions RepackOptions,UObject Debug/*=nullptr*/) { return default; }
	public UObject AutoGeneratePatchBuilderMeshUVs(UObject TargetMesh,int UVSetIndex,FGeometryScriptPatchBuilderOptions Options,UObject Debug/*=nullptr*/) { return default; }
	public UObject AutoGenerateXAtlasMeshUVs(UObject TargetMesh,int UVSetIndex,FGeometryScriptXAtlasOptions Options,UObject Debug/*=nullptr*/) { return default; }
	public UObject GetMeshUVSizeInfo(UObject TargetMesh,int UVSetIndex,FGeometryScriptMeshSelection Selection,double MeshArea,double UVArea,FBox MeshBounds,FBox2D UVBounds,bool bIsValidUVSet,bool bFoundUnsetUVs,bool bOnlyIncludeValidUVTris/*=true*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject GetMeshPerVertexUVs(UObject TargetMesh,int UVSetIndex,FGeometryScriptUVList UVList,bool bIsValidUVSet,bool bHasVertexIDGaps,bool bHasSplitUVs,UObject Debug/*=nullptr*/) { return default; }
	public UObject CopyMeshUVLayerToMesh(UObject CopyFromMesh,int UVSetIndex,UObject CopyToUVMesh,UObject CopyToUVMeshOut,bool bInvalidTopology,bool bIsValidUVSet,UObject Debug/*=nullptr*/) { return default; }
	public UObject CopyMeshToMeshUVLayer(UObject CopyFromUVMesh,int ToUVSetIndex,UObject CopyToMesh,UObject CopyToMeshOut,bool bFoundTopologyErrors,bool bIsValidUVSet,bool bOnlyUVPositions/*=true*/,UObject Debug/*=nullptr*/) { return default; }
}
