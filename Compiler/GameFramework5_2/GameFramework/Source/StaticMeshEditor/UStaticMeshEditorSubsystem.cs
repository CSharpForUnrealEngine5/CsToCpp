#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StaticMeshEditorSubsystem.h")]
///<summary>UStaticMeshEditorSubsystem</summary>
public partial class UStaticMeshEditorSubsystem : UEditorSubsystem {
// StaticMeshEditorSubsystem
	public  int SetLodsWithNotification(UStaticMesh StaticMesh,FStaticMeshReductionOptions ReductionOptions,bool bApplyChanges) { return default; }
	public  int SetLods(UStaticMesh StaticMesh,FStaticMeshReductionOptions ReductionOptions) { return default; }
	public  void GetLodReductionSettings(UStaticMesh StaticMesh,int LodIndex,FMeshReductionSettings OutReductionOptions) {}
	public  void SetLodReductionSettings(UStaticMesh StaticMesh,int LodIndex,FMeshReductionSettings ReductionOptions) {}
	public  void GetLodBuildSettings(UStaticMesh StaticMesh,int LodIndex,FMeshBuildSettings OutBuildOptions) {}
	public  void SetLodBuildSettings(UStaticMesh StaticMesh,int LodIndex,FMeshBuildSettings BuildOptions) {}
	public  string GetLODGroup(UStaticMesh StaticMesh) { return default; }
	public  bool SetLODGroup(UStaticMesh StaticMesh,string LODGroup,bool bRebuildImmediately/*=true*/) { return default; }
	public  int ImportLOD(UStaticMesh BaseStaticMesh,int LODIndex,string SourceFilename) { return default; }
	public  bool ReimportAllCustomLODs(UStaticMesh StaticMesh) { return default; }
	public  int SetLodFromStaticMesh(UStaticMesh DestinationStaticMesh,int DestinationLodIndex,UStaticMesh SourceStaticMesh,int SourceLodIndex,bool bReuseExistingMaterialSlots) { return default; }
	public  int GetLodCount(UStaticMesh StaticMesh) { return default; }
	public  bool RemoveLods(UStaticMesh StaticMesh) { return default; }
	public  TArray<float> GetLodScreenSizes(UStaticMesh StaticMesh) { return default; }
	public  bool SetLodScreenSizes(UStaticMesh StaticMesh,TArray<float> ScreenSizes) { return default; }
	public  FMeshNaniteSettings GetNaniteSettings(UStaticMesh StaticMesh) { return default; }
	public  void SetNaniteSettings(UStaticMesh StaticMesh,FMeshNaniteSettings NaniteSettings,bool bApplyChanges/*=true*/) {}
	public  int AddSimpleCollisionsWithNotification(UStaticMesh StaticMesh,EScriptCollisionShapeType ShapeType,bool bApplyChanges) { return default; }
	public  int AddSimpleCollisions(UStaticMesh StaticMesh,EScriptCollisionShapeType ShapeType) { return default; }
	public  int GetSimpleCollisionCount(UStaticMesh StaticMesh) { return default; }
	public  ECollisionTraceFlag GetCollisionComplexity(UStaticMesh StaticMesh) { return default; }
	public  int GetConvexCollisionCount(UStaticMesh StaticMesh) { return default; }
	public  bool SetConvexDecompositionCollisionsWithNotification(UStaticMesh StaticMesh,int HullCount,int MaxHullVerts,int HullPrecision,bool bApplyChanges) { return default; }
	public  bool BulkSetConvexDecompositionCollisionsWithNotification(TArray<UStaticMesh> StaticMeshes,int HullCount,int MaxHullVerts,int HullPrecision,bool bApplyChanges) { return default; }
	public  bool SetConvexDecompositionCollisions(UStaticMesh StaticMesh,int HullCount,int MaxHullVerts,int HullPrecision) { return default; }
	public  bool BulkSetConvexDecompositionCollisions(TArray<UStaticMesh> StaticMeshes,int HullCount,int MaxHullVerts,int HullPrecision) { return default; }
	public  bool RemoveCollisionsWithNotification(UStaticMesh StaticMesh,bool bApplyChanges) { return default; }
	public  bool RemoveCollisions(UStaticMesh StaticMesh) { return default; }
	public  void EnableSectionCollision(UStaticMesh StaticMesh,bool bCollisionEnabled,int LODIndex,int SectionIndex) {}
	public  bool IsSectionCollisionEnabled(UStaticMesh StaticMesh,int LODIndex,int SectionIndex) { return default; }
	public  void EnableSectionCastShadow(UStaticMesh StaticMesh,bool bCastShadow,int LODIndex,int SectionIndex) {}
	public  void SetLODMaterialSlot(UStaticMesh StaticMesh,int MaterialSlotIndex,int LODIndex,int SectionIndex) {}
	public  int GetLODMaterialSlot(UStaticMesh StaticMesh,int LODIndex,int SectionIndex) { return default; }
	public  bool HasVertexColors(UStaticMesh StaticMesh) { return default; }
	public  bool HasInstanceVertexColors(UStaticMeshComponent StaticMeshComponent) { return default; }
	public  bool SetGenerateLightmapUVs(UStaticMesh StaticMesh,bool bGenerateLightmapUVs) { return default; }
	public  int GetNumberVerts(UStaticMesh StaticMesh,int LODIndex) { return default; }
	public  int GetNumberMaterials(UStaticMesh StaticMesh) { return default; }
	public  void SetAllowCPUAccess(UStaticMesh StaticMesh,bool bAllowCPUAccess) {}
	public  int GetNumUVChannels(UStaticMesh StaticMesh,int LODIndex) { return default; }
	public  bool AddUVChannel(UStaticMesh StaticMesh,int LODIndex) { return default; }
	public  bool InsertUVChannel(UStaticMesh StaticMesh,int LODIndex,int UVChannelIndex) { return default; }
	public  bool RemoveUVChannel(UStaticMesh StaticMesh,int LODIndex,int UVChannelIndex) { return default; }
	public  bool GeneratePlanarUVChannel(UStaticMesh StaticMesh,int LODIndex,int UVChannelIndex,FVector Position,FRotator Orientation,FVector2D Tiling) { return default; }
	public  bool GenerateCylindricalUVChannel(UStaticMesh StaticMesh,int LODIndex,int UVChannelIndex,FVector Position,FRotator Orientation,FVector2D Tiling) { return default; }
	public  bool GenerateBoxUVChannel(UStaticMesh StaticMesh,int LODIndex,int UVChannelIndex,FVector Position,FRotator Orientation,FVector Size) { return default; }
	public  void ReplaceMeshComponentsMaterials(TArray<UMeshComponent> MeshComponents,UMaterialInterface MaterialToBeReplaced,UMaterialInterface NewMaterial) {}
	public  void ReplaceMeshComponentsMaterialsOnActors(TArray<AActor> Actors,UMaterialInterface MaterialToBeReplaced,UMaterialInterface NewMaterial) {}
	public  void ReplaceMeshComponentsMeshes(TArray<UStaticMeshComponent> MeshComponents,UStaticMesh MeshToBeReplaced,UStaticMesh NewMesh) {}
	public  void ReplaceMeshComponentsMeshesOnActors(TArray<AActor> Actors,UStaticMesh MeshToBeReplaced,UStaticMesh NewMesh) {}
	public  AActor JoinStaticMeshActors(TArray<AStaticMeshActor> ActorsToJoin,FJoinStaticMeshActorsOptions JoinOptions) { return default; }
	public  bool MergeStaticMeshActors(TArray<AStaticMeshActor> ActorsToMerge,FMergeStaticMeshActorsOptions MergeOptions,AStaticMeshActor OutMergedActor) { return default; }
	public  bool CreateProxyMeshActor(TArray<AStaticMeshActor> ActorsToMerge,FCreateProxyMeshActorOptions MergeOptions,AStaticMeshActor OutMergedActor) { return default; }
}
