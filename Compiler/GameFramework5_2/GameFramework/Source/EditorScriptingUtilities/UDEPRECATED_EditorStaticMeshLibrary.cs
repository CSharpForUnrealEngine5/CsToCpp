namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Utility class to altering and analyzing a StaticMesh and use the common functionalities of the Mesh Editor.</summary>
[CppInclude("EditorStaticMeshLibrary.h")]
public partial class UDEPRECATED_EditorStaticMeshLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>GetLodReductionSettings</summary>
	public static void GetLodReductionSettings(UStaticMesh StaticMesh,int LodIndex,FMeshReductionSettings OutReductionOptions) {}
	///<summary>SetLodReductionSettings</summary>
	public static void SetLodReductionSettings(UStaticMesh StaticMesh,int LodIndex,FMeshReductionSettings ReductionOptions) {}
	///<summary>GetLodBuildSettings</summary>
	public static void GetLodBuildSettings(UStaticMesh StaticMesh,int LodIndex,FMeshBuildSettings OutBuildOptions) {}
	///<summary>SetLodBuildSettings</summary>
	public static void SetLodBuildSettings(UStaticMesh StaticMesh,int LodIndex,FMeshBuildSettings BuildOptions) {}
	///<summary>ImportLOD</summary>
	public static int ImportLOD(UStaticMesh BaseStaticMesh,int LODIndex,string SourceFilename) { return default; }
	///<summary>ReimportAllCustomLODs</summary>
	public static bool ReimportAllCustomLODs(UStaticMesh StaticMesh) { return default; }
	///<summary>SetLodFromStaticMesh</summary>
	public static int SetLodFromStaticMesh(UStaticMesh DestinationStaticMesh,int DestinationLodIndex,UStaticMesh SourceStaticMesh,int SourceLodIndex,bool bReuseExistingMaterialSlots) { return default; }
	///<summary>GetLodCount</summary>
	public static int GetLodCount(UStaticMesh StaticMesh) { return default; }
	///<summary>RemoveLods</summary>
	public static bool RemoveLods(UStaticMesh StaticMesh) { return default; }
	///<summary>GetLodScreenSizes</summary>
	public static TArray<float> GetLodScreenSizes(UStaticMesh StaticMesh) { return default; }
	///<summary>GetSimpleCollisionCount</summary>
	public static int GetSimpleCollisionCount(UStaticMesh StaticMesh) { return default; }
	///<summary>GetCollisionComplexity</summary>
	public static ECollisionTraceFlag GetCollisionComplexity(UStaticMesh StaticMesh) { return default; }
	///<summary>GetConvexCollisionCount</summary>
	public static int GetConvexCollisionCount(UStaticMesh StaticMesh) { return default; }
	///<summary>SetConvexDecompositionCollisionsWithNotification</summary>
	public static bool SetConvexDecompositionCollisionsWithNotification(UStaticMesh StaticMesh,int HullCount,int MaxHullVerts,int HullPrecision,bool bApplyChanges) { return default; }
	///<summary>BulkSetConvexDecompositionCollisionsWithNotification</summary>
	public static bool BulkSetConvexDecompositionCollisionsWithNotification(TArray<UStaticMesh> StaticMeshes,int HullCount,int MaxHullVerts,int HullPrecision,bool bApplyChanges) { return default; }
	///<summary>SetConvexDecompositionCollisions</summary>
	public static bool SetConvexDecompositionCollisions(UStaticMesh StaticMesh,int HullCount,int MaxHullVerts,int HullPrecision) { return default; }
	///<summary>BulkSetConvexDecompositionCollisions</summary>
	public static bool BulkSetConvexDecompositionCollisions(TArray<UStaticMesh> StaticMeshes,int HullCount,int MaxHullVerts,int HullPrecision) { return default; }
	///<summary>RemoveCollisionsWithNotification</summary>
	public static bool RemoveCollisionsWithNotification(UStaticMesh StaticMesh,bool bApplyChanges) { return default; }
	///<summary>RemoveCollisions</summary>
	public static bool RemoveCollisions(UStaticMesh StaticMesh) { return default; }
	///<summary>EnableSectionCollision</summary>
	public static void EnableSectionCollision(UStaticMesh StaticMesh,bool bCollisionEnabled,int LODIndex,int SectionIndex) {}
	///<summary>IsSectionCollisionEnabled</summary>
	public static bool IsSectionCollisionEnabled(UStaticMesh StaticMesh,int LODIndex,int SectionIndex) { return default; }
	///<summary>EnableSectionCastShadow</summary>
	public static void EnableSectionCastShadow(UStaticMesh StaticMesh,bool bCastShadow,int LODIndex,int SectionIndex) {}
	///<summary>HasVertexColors</summary>
	public static bool HasVertexColors(UStaticMesh StaticMesh) { return default; }
	///<summary>HasInstanceVertexColors</summary>
	public static bool HasInstanceVertexColors(UStaticMeshComponent StaticMeshComponent) { return default; }
	///<summary>SetGenerateLightmapUVs</summary>
	public static bool SetGenerateLightmapUVs(UStaticMesh StaticMesh,bool bGenerateLightmapUVs) { return default; }
	///<summary>GetNumberVerts</summary>
	public static int GetNumberVerts(UStaticMesh StaticMesh,int LODIndex) { return default; }
	///<summary>GetNumberMaterials</summary>
	public static int GetNumberMaterials(UStaticMesh StaticMesh) { return default; }
	///<summary>SetAllowCPUAccess</summary>
	public static void SetAllowCPUAccess(UStaticMesh StaticMesh,bool bAllowCPUAccess) {}
	///<summary>GetNumUVChannels</summary>
	public static int GetNumUVChannels(UStaticMesh StaticMesh,int LODIndex) { return default; }
	///<summary>AddUVChannel</summary>
	public static bool AddUVChannel(UStaticMesh StaticMesh,int LODIndex) { return default; }
	///<summary>InsertUVChannel</summary>
	public static bool InsertUVChannel(UStaticMesh StaticMesh,int LODIndex,int UVChannelIndex) { return default; }
	///<summary>RemoveUVChannel</summary>
	public static bool RemoveUVChannel(UStaticMesh StaticMesh,int LODIndex,int UVChannelIndex) { return default; }
	///<summary>GeneratePlanarUVChannel</summary>
	public static bool GeneratePlanarUVChannel(UStaticMesh StaticMesh,int LODIndex,int UVChannelIndex,FVector Position,FRotator Orientation,FVector2D Tiling) { return default; }
	///<summary>GenerateCylindricalUVChannel</summary>
	public static bool GenerateCylindricalUVChannel(UStaticMesh StaticMesh,int LODIndex,int UVChannelIndex,FVector Position,FRotator Orientation,FVector2D Tiling) { return default; }
	///<summary>GenerateBoxUVChannel</summary>
	public static bool GenerateBoxUVChannel(UStaticMesh StaticMesh,int LODIndex,int UVChannelIndex,FVector Position,FRotator Orientation,FVector Size) { return default; }
	///<summary>SetLodsWithNotification</summary>
	public static int SetLodsWithNotification(UStaticMesh StaticMesh,FStaticMeshReductionOptions ReductionOptions,bool bApplyChanges) { return default; }
	///<summary>SetLods</summary>
	public static int SetLods(UStaticMesh StaticMesh,FStaticMeshReductionOptions ReductionOptions) { return default; }
	///<summary>AddSimpleCollisionsWithNotification</summary>
	public static int AddSimpleCollisionsWithNotification(UStaticMesh StaticMesh,EScriptCollisionShapeType ShapeType,bool bApplyChanges) { return default; }
	///<summary>AddSimpleCollisions</summary>
	public static int AddSimpleCollisions(UStaticMesh StaticMesh,EScriptCollisionShapeType ShapeType) { return default; }
}
