#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorStaticMeshLibrary.h")]
///<summary>Utility class to altering and analyzing a StaticMesh and use the common functionalities of the Mesh Editor.</summary>
public partial class UDEPRECATED_EditorStaticMeshLibrary : UBlueprintFunctionLibrary {
// EditorStaticMeshLibrary
	public void GetLodReductionSettings(UObject StaticMesh,int LodIndex,FMeshReductionSettings OutReductionOptions) {}
	public void SetLodReductionSettings(UObject StaticMesh,int LodIndex,FMeshReductionSettings ReductionOptions) {}
	public void GetLodBuildSettings(UObject StaticMesh,int LodIndex,FMeshBuildSettings OutBuildOptions) {}
	public void SetLodBuildSettings(UObject StaticMesh,int LodIndex,FMeshBuildSettings BuildOptions) {}
	public int ImportLOD(UObject BaseStaticMesh,int LODIndex,string SourceFilename) { return default; }
	public bool ReimportAllCustomLODs(UObject StaticMesh) { return default; }
	public int SetLodFromStaticMesh(UObject DestinationStaticMesh,int DestinationLodIndex,UObject SourceStaticMesh,int SourceLodIndex,bool bReuseExistingMaterialSlots) { return default; }
	public int GetLodCount(UObject StaticMesh) { return default; }
	public bool RemoveLods(UObject StaticMesh) { return default; }
	public TArray<float> GetLodScreenSizes(UObject StaticMesh) { return default; }
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
	public int SetLodsWithNotification(UObject StaticMesh,FStaticMeshReductionOptions ReductionOptions,bool bApplyChanges) { return default; }
	public int SetLods(UObject StaticMesh,FStaticMeshReductionOptions ReductionOptions) { return default; }
	public int AddSimpleCollisionsWithNotification(UObject StaticMesh,EScriptCollisionShapeType ShapeType,bool bApplyChanges) { return default; }
	public int AddSimpleCollisions(UObject StaticMesh,EScriptCollisionShapeType ShapeType) { return default; }
}
