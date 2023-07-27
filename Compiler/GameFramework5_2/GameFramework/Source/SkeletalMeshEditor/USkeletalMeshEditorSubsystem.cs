#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SkeletalMeshEditorSubsystem.h")]
///<summary>USkeletalMeshEditorSubsystem</summary>
public partial class USkeletalMeshEditorSubsystem : UEditorSubsystem {
// SkeletalMeshEditorSubsystem
	public static bool RegenerateLOD(USkeletalMesh SkeletalMesh,int NewLODCount/*=0*/,bool bRegenerateEvenIfImported/*=false*/,bool bGenerateBaseLOD/*=false*/) { return default; }
	public  int GetNumVerts(USkeletalMesh SkeletalMesh,int LODIndex) { return default; }
	public  int GetNumSections(USkeletalMesh SkeletalMesh,int LODIndex) { return default; }
	public  bool GetSectionRecomputeTangent(USkeletalMesh SkeletalMesh,int LODIndex,int SectionIndex,bool bOutRecomputeTangent) { return default; }
	public  bool SetSectionRecomputeTangent(USkeletalMesh SkeletalMesh,int LODIndex,int SectionIndex,bool bRecomputeTangent) { return default; }
	public  bool GetSectionRecomputeTangentsVertexMaskChannel(USkeletalMesh SkeletalMesh,int LODIndex,int SectionIndex,byte OutRecomputeTangentsVertexMaskChannel) { return default; }
	public  bool SetSectionRecomputeTangentsVertexMaskChannel(USkeletalMesh SkeletalMesh,int LODIndex,int SectionIndex,byte RecomputeTangentsVertexMaskChannel) { return default; }
	public  bool GetSectionCastShadow(USkeletalMesh SkeletalMesh,int LODIndex,int SectionIndex,bool bOutCastShadow) { return default; }
	public  bool SetSectionCastShadow(USkeletalMesh SkeletalMesh,int LODIndex,int SectionIndex,bool bCastShadow) { return default; }
	public  bool GetSectionVisibleInRayTracing(USkeletalMesh SkeletalMesh,int LODIndex,int SectionIndex,bool bOutVisibleInRayTracing) { return default; }
	public  bool SetSectionVisibleInRayTracing(USkeletalMesh SkeletalMesh,int LODIndex,int SectionIndex,bool bVisibleInRayTracing) { return default; }
	public  int GetLODMaterialSlot(USkeletalMesh SkeletalMesh,int LODIndex,int SectionIndex) { return default; }
	public static bool RenameSocket(USkeletalMesh SkeletalMesh,string OldName,string NewName) { return default; }
	public static int GetLODCount(USkeletalMesh SkeletalMesh) { return default; }
	public static int ImportLOD(USkeletalMesh BaseMesh,int LODIndex,string SourceFilename) { return default; }
	public static bool ReimportAllCustomLODs(USkeletalMesh SkeletalMesh) { return default; }
	public static void GetLodBuildSettings(USkeletalMesh SkeletalMesh,int LodIndex,FSkeletalMeshBuildSettings OutBuildOptions) {}
	public static void SetLodBuildSettings(USkeletalMesh SkeletalMesh,int LodIndex,FSkeletalMeshBuildSettings BuildOptions) {}
	public static UPhysicsAsset CreatePhysicsAsset(USkeletalMesh SkeletalMesh) { return default; }
}
