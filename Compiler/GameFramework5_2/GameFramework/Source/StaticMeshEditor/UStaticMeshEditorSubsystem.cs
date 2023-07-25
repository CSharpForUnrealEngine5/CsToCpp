#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StaticMeshEditorSubsystem.h")]
///<summary>UStaticMeshEditorSubsystem</summary>
public partial class UStaticMeshEditorSubsystem : UEditorSubsystem {
// StaticMeshEditorSubsystem
	public int SetLodsWithNotification(UObject StaticMesh,FStaticMeshReductionOptions ReductionOptions,bool bApplyChanges) { return default; }
	public int SetLods(UObject StaticMesh,FStaticMeshReductionOptions ReductionOptions) { return default; }
	public void GetLodReductionSettings(UObject StaticMesh,int LodIndex,FMeshReductionSettings OutReductionOptions) {}
	public void SetLodReductionSettings(UObject StaticMesh,int LodIndex,FMeshReductionSettings ReductionOptions) {}
	public void GetLodBuildSettings(UObject StaticMesh,int LodIndex,FMeshBuildSettings OutBuildOptions) {}
	public void SetLodBuildSettings(UObject StaticMesh,int LodIndex,FMeshBuildSettings BuildOptions) {}
	public string GetLODGroup(UObject StaticMesh) { return default; }
	public bool SetLODGroup(UObject StaticMesh,string LODGroup,bool bRebuildImmediately/*=true*/) { return default; }
	public int ImportLOD(UObject BaseStaticMesh,int LODIndex,string SourceFilename) { return default; }
	public bool ReimportAllCustomLODs(UObject StaticMesh) { return default; }
	public int SetLodFromStaticMesh(UObject DestinationStaticMesh,int DestinationLodIndex,UObject SourceStaticMesh,int SourceLodIndex,bool bReuseExistingMaterialSlots) { return default; }
	public int GetLodCount(UObject StaticMesh) { return default; }
	public bool RemoveLods(UObject StaticMesh) { return default; }
	public TArray<float> GetLodScreenSizes(UObject StaticMesh) { return default; }
	public bool SetLodScreenSizes(UObject StaticMesh,TArray<float> ScreenSizes) { return default; }
	public FMeshNaniteSettings GetNaniteSettings(UObject StaticMesh) { return default; }
	public void SetNaniteSettings(UObject StaticMesh,FMeshNaniteSettings NaniteSettings,bool bApplyChanges/*=true*/) {}
	public int AddSimpleCollisionsWithNotification(UObject StaticMesh,EScriptCollisionShapeType ShapeType,bool bApplyChanges) { return default; }
	public int AddSimpleCollisions(UObject StaticMesh,EScriptCollisionShapeType ShapeType) { return default; }
	public int GetSimpleCollisionCount(UObject StaticMesh) { return default; }
	public byte GetCollisionComplexity(UObject StaticMesh) { return default; }
	public int GetConvexCollisionCount(UObject StaticMesh) { return default; }
	public bool SetConvexDecompositionCollisionsWithNotification(UObject StaticMesh,int HullCount,int MaxHullVerts,int HullPrecision,bool bApplyChanges) { return default; }
	public bool BulkSetConvexDecompositionCollisionsWithNotification(TArray<UObject> StaticMeshes,int HullCount,int MaxHullVerts,int HullPrecision,bool bApplyChanges) { return default; }
	public bool SetConvexDecompositionCollisions(UObject StaticMesh,int HullCount,int MaxHullVerts,int HullPrecision) { return default; }
	public bool BulkSetConvexDecompositionCollisions(TArray<UObject> StaticMeshes,int HullCount,int MaxHullVerts,int HullPrecision) { return default; }
	public bool RemoveCollisionsWithNotification(UObject StaticMesh,bool bApplyChanges) { return default; }
	public bool RemoveCollisions(UObject StaticMesh) { return default; }
	public void EnableSectionCollision(UObject StaticMesh,bool bCollisionEnabled,int LODIndex,int SectionIndex) {}
	public bool IsSectionCollisionEnabled(UObject StaticMesh,int LODIndex,int SectionIndex) { return default; }
	public void EnableSectionCastShadow(UObject StaticMesh,bool bCastShadow,int LODIndex,int SectionIndex) {}
	public void SetLODMaterialSlot(UObject StaticMesh,int MaterialSlotIndex,int LODIndex,int SectionIndex) {}
	public int GetLODMaterialSlot(UObject StaticMesh,int LODIndex,int SectionIndex) { return default; }
	public bool HasVertexColors(UObject StaticMesh) { return default; }
	public bool HasInstanceVertexColors(UObject StaticMeshComponent) { return default; }
	public bool SetGenerateLightmapUVs(UObject StaticMesh,bool bGenerateLightmapUVs) { return default; }
	public int GetNumberVerts(UObject StaticMesh,int LODIndex) { return default; }
	public int GetNumberMaterials(UObject StaticMesh) { return default; }
	public void SetAllowCPUAccess(UObject StaticMesh,bool bAllowCPUAccess) {}
	public int GetNumUVChannels(UObject StaticMesh,int LODIndex) { return default; }
	public bool AddUVChannel(UObject StaticMesh,int LODIndex) { return default; }
	public bool InsertUVChannel(UObject StaticMesh,int LODIndex,int UVChannelIndex) { return default; }
	public bool RemoveUVChannel(UObject StaticMesh,int LODIndex,int UVChannelIndex) { return default; }
	public bool GeneratePlanarUVChannel(UObject StaticMesh,int LODIndex,int UVChannelIndex,FVector Position,FRotator Orientation,FVector2D Tiling) { return default; }
	public bool GenerateCylindricalUVChannel(UObject StaticMesh,int LODIndex,int UVChannelIndex,FVector Position,FRotator Orientation,FVector2D Tiling) { return default; }
	public bool GenerateBoxUVChannel(UObject StaticMesh,int LODIndex,int UVChannelIndex,FVector Position,FRotator Orientation,FVector Size) { return default; }
	public void ReplaceMeshComponentsMaterials(TArray<UObject> MeshComponents,UObject MaterialToBeReplaced,UObject NewMaterial) {}
	public void ReplaceMeshComponentsMaterialsOnActors(TArray<UObject> Actors,UObject MaterialToBeReplaced,UObject NewMaterial) {}
	public void ReplaceMeshComponentsMeshes(TArray<UObject> MeshComponents,UObject MeshToBeReplaced,UObject NewMesh) {}
	public void ReplaceMeshComponentsMeshesOnActors(TArray<UObject> Actors,UObject MeshToBeReplaced,UObject NewMesh) {}
	public UObject JoinStaticMeshActors(TArray<UObject> ActorsToJoin,FJoinStaticMeshActorsOptions JoinOptions) { return default; }
	public bool MergeStaticMeshActors(TArray<UObject> ActorsToMerge,FMergeStaticMeshActorsOptions MergeOptions,UObject OutMergedActor) { return default; }
	public bool CreateProxyMeshActor(TArray<UObject> ActorsToMerge,FCreateProxyMeshActorOptions MergeOptions,UObject OutMergedActor) { return default; }
}
