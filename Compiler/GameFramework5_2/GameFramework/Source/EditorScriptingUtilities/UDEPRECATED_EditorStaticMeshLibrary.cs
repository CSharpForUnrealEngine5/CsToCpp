#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorStaticMeshLibrary.h")]
///<summary>Utility class to altering and analyzing a StaticMesh and use the common functionalities of the Mesh Editor.</summary>
public partial class UDEPRECATED_EditorStaticMeshLibrary : UBlueprintFunctionLibrary {
// EditorStaticMeshLibrary
	public static void GetLodReductionSettings(UStaticMesh StaticMesh,int LodIndex,FMeshReductionSettings OutReductionOptions) {}
	public static void SetLodReductionSettings(UStaticMesh StaticMesh,int LodIndex,FMeshReductionSettings ReductionOptions) {}
	public static void GetLodBuildSettings(UStaticMesh StaticMesh,int LodIndex,FMeshBuildSettings OutBuildOptions) {}
	public static void SetLodBuildSettings(UStaticMesh StaticMesh,int LodIndex,FMeshBuildSettings BuildOptions) {}
	public static int ImportLOD(UStaticMesh BaseStaticMesh,int LODIndex,string SourceFilename) { return default; }
	public static bool ReimportAllCustomLODs(UStaticMesh StaticMesh) { return default; }
	public static int SetLodFromStaticMesh(UStaticMesh DestinationStaticMesh,int DestinationLodIndex,UStaticMesh SourceStaticMesh,int SourceLodIndex,bool bReuseExistingMaterialSlots) { return default; }
	public static int GetLodCount(UStaticMesh StaticMesh) { return default; }
	public static bool RemoveLods(UStaticMesh StaticMesh) { return default; }
	public static TArray<float> GetLodScreenSizes(UStaticMesh StaticMesh) { return default; }
	public static int GetSimpleCollisionCount(UStaticMesh StaticMesh) { return default; }
	public static ECollisionTraceFlag GetCollisionComplexity(UStaticMesh StaticMesh) { return default; }
	public static int GetConvexCollisionCount(UStaticMesh StaticMesh) { return default; }
	public static bool SetConvexDecompositionCollisionsWithNotification(UStaticMesh StaticMesh,int HullCount,int MaxHullVerts,int HullPrecision,bool bApplyChanges) { return default; }
	public static bool BulkSetConvexDecompositionCollisionsWithNotification(TArray<UStaticMesh> StaticMeshes,int HullCount,int MaxHullVerts,int HullPrecision,bool bApplyChanges) { return default; }
	public static bool SetConvexDecompositionCollisions(UStaticMesh StaticMesh,int HullCount,int MaxHullVerts,int HullPrecision) { return default; }
	public static bool BulkSetConvexDecompositionCollisions(TArray<UStaticMesh> StaticMeshes,int HullCount,int MaxHullVerts,int HullPrecision) { return default; }
	public static bool RemoveCollisionsWithNotification(UStaticMesh StaticMesh,bool bApplyChanges) { return default; }
	public static bool RemoveCollisions(UStaticMesh StaticMesh) { return default; }
	public static void EnableSectionCollision(UStaticMesh StaticMesh,bool bCollisionEnabled,int LODIndex,int SectionIndex) {}
	public static bool IsSectionCollisionEnabled(UStaticMesh StaticMesh,int LODIndex,int SectionIndex) { return default; }
	public static void EnableSectionCastShadow(UStaticMesh StaticMesh,bool bCastShadow,int LODIndex,int SectionIndex) {}
	public static bool HasVertexColors(UStaticMesh StaticMesh) { return default; }
	public static bool HasInstanceVertexColors(UStaticMeshComponent StaticMeshComponent) { return default; }
	public static bool SetGenerateLightmapUVs(UStaticMesh StaticMesh,bool bGenerateLightmapUVs) { return default; }
	public static int GetNumberVerts(UStaticMesh StaticMesh,int LODIndex) { return default; }
	public static int GetNumberMaterials(UStaticMesh StaticMesh) { return default; }
	public static void SetAllowCPUAccess(UStaticMesh StaticMesh,bool bAllowCPUAccess) {}
	public static int GetNumUVChannels(UStaticMesh StaticMesh,int LODIndex) { return default; }
	public static bool AddUVChannel(UStaticMesh StaticMesh,int LODIndex) { return default; }
	public static bool InsertUVChannel(UStaticMesh StaticMesh,int LODIndex,int UVChannelIndex) { return default; }
	public static bool RemoveUVChannel(UStaticMesh StaticMesh,int LODIndex,int UVChannelIndex) { return default; }
	public static bool GeneratePlanarUVChannel(UStaticMesh StaticMesh,int LODIndex,int UVChannelIndex,FVector Position,FRotator Orientation,FVector2D Tiling) { return default; }
	public static bool GenerateCylindricalUVChannel(UStaticMesh StaticMesh,int LODIndex,int UVChannelIndex,FVector Position,FRotator Orientation,FVector2D Tiling) { return default; }
	public static bool GenerateBoxUVChannel(UStaticMesh StaticMesh,int LODIndex,int UVChannelIndex,FVector Position,FRotator Orientation,FVector Size) { return default; }
	public static int SetLodsWithNotification(UStaticMesh StaticMesh,FStaticMeshReductionOptions ReductionOptions,bool bApplyChanges) { return default; }
	public static int SetLods(UStaticMesh StaticMesh,FStaticMeshReductionOptions ReductionOptions) { return default; }
	public static int AddSimpleCollisionsWithNotification(UStaticMesh StaticMesh,EScriptCollisionShapeType ShapeType,bool bApplyChanges) { return default; }
	public static int AddSimpleCollisions(UStaticMesh StaticMesh,EScriptCollisionShapeType ShapeType) { return default; }
}
