#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorSkeletalMeshLibrary.h")]
///<summary>Utility class to altering and analyzing a SkeletalMesh and use the common functionalities of the SkeletalMesh Editor.</summary>
public partial class UDEPRECATED_EditorSkeletalMeshLibrary : UBlueprintFunctionLibrary {
// EditorSkeletalMeshLibrary
	public static bool RegenerateLOD(USkeletalMesh SkeletalMesh,int NewLODCount/*=0*/,bool bRegenerateEvenIfImported/*=false*/,bool bGenerateBaseLOD/*=false*/) { return default; }
	public static int GetNumVerts(USkeletalMesh SkeletalMesh,int LODIndex) { return default; }
	public static bool RenameSocket(USkeletalMesh SkeletalMesh,string OldName,string NewName) { return default; }
	public static int GetLODCount(USkeletalMesh SkeletalMesh) { return default; }
	public static int ImportLOD(USkeletalMesh BaseMesh,int LODIndex,string SourceFilename) { return default; }
	public static bool ReimportAllCustomLODs(USkeletalMesh SkeletalMesh) { return default; }
	public static void GetLodBuildSettings(USkeletalMesh SkeletalMesh,int LodIndex,FSkeletalMeshBuildSettings OutBuildOptions) {}
	public static void SetLodBuildSettings(USkeletalMesh SkeletalMesh,int LodIndex,FSkeletalMeshBuildSettings BuildOptions) {}
	public static bool RemoveLODs(USkeletalMesh SkeletalMesh,TArray<int> ToRemoveLODs) { return default; }
	public static bool StripLODGeometry(USkeletalMesh SkeletalMesh,int LODIndex,UTexture2D TextureMask,float Threshold) { return default; }
	public static UPhysicsAsset CreatePhysicsAsset(USkeletalMesh SkeletalMesh) { return default; }
}
