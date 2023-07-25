#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SkeletalMeshEditorSubsystem.h")]
///<summary>USkeletalMeshEditorSubsystem</summary>
public partial class USkeletalMeshEditorSubsystem : UEditorSubsystem {
// SkeletalMeshEditorSubsystem
	public bool RegenerateLOD(UObject SkeletalMesh,int NewLODCount/*=0*/,bool bRegenerateEvenIfImported/*=false*/,bool bGenerateBaseLOD/*=false*/) { return default; }
	public int GetNumVerts(UObject SkeletalMesh,int LODIndex) { return default; }
	public int GetNumSections(UObject SkeletalMesh,int LODIndex) { return default; }
	public bool GetSectionRecomputeTangent(UObject SkeletalMesh,int LODIndex,int SectionIndex,bool bOutRecomputeTangent) { return default; }
	public bool SetSectionRecomputeTangent(UObject SkeletalMesh,int LODIndex,int SectionIndex,bool bRecomputeTangent) { return default; }
	public bool GetSectionRecomputeTangentsVertexMaskChannel(UObject SkeletalMesh,int LODIndex,int SectionIndex,byte OutRecomputeTangentsVertexMaskChannel) { return default; }
	public bool SetSectionRecomputeTangentsVertexMaskChannel(UObject SkeletalMesh,int LODIndex,int SectionIndex,byte RecomputeTangentsVertexMaskChannel) { return default; }
	public bool GetSectionCastShadow(UObject SkeletalMesh,int LODIndex,int SectionIndex,bool bOutCastShadow) { return default; }
	public bool SetSectionCastShadow(UObject SkeletalMesh,int LODIndex,int SectionIndex,bool bCastShadow) { return default; }
	public bool GetSectionVisibleInRayTracing(UObject SkeletalMesh,int LODIndex,int SectionIndex,bool bOutVisibleInRayTracing) { return default; }
	public bool SetSectionVisibleInRayTracing(UObject SkeletalMesh,int LODIndex,int SectionIndex,bool bVisibleInRayTracing) { return default; }
	public int GetLODMaterialSlot(UObject SkeletalMesh,int LODIndex,int SectionIndex) { return default; }
	public bool RenameSocket(UObject SkeletalMesh,string OldName,string NewName) { return default; }
	public int GetLODCount(UObject SkeletalMesh) { return default; }
	public int ImportLOD(UObject BaseMesh,int LODIndex,string SourceFilename) { return default; }
	public bool ReimportAllCustomLODs(UObject SkeletalMesh) { return default; }
	public void GetLodBuildSettings(UObject SkeletalMesh,int LodIndex,FSkeletalMeshBuildSettings OutBuildOptions) {}
	public void SetLodBuildSettings(UObject SkeletalMesh,int LodIndex,FSkeletalMeshBuildSettings BuildOptions) {}
	public UObject CreatePhysicsAsset(UObject SkeletalMesh) { return default; }
}
