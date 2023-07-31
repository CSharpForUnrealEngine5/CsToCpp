#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Utility class to altering and analyzing a SkeletalMesh and use the common functionalities of the SkeletalMesh Editor.</summary>
[CppInclude("EditorSkeletalMeshLibrary.h")]
public partial class UDEPRECATED_EditorSkeletalMeshLibrary : UBlueprintFunctionLibrary {
	///<summary>RegenerateLOD</summary>
	public static bool RegenerateLOD(USkeletalMesh SkeletalMesh,int NewLODCount/*=0*/,bool bRegenerateEvenIfImported/*=false*/,bool bGenerateBaseLOD/*=false*/) { return default; }
	///<summary>GetNumVerts</summary>
	public static int GetNumVerts(USkeletalMesh SkeletalMesh,int LODIndex) { return default; }
	///<summary>RenameSocket</summary>
	public static bool RenameSocket(USkeletalMesh SkeletalMesh,string OldName,string NewName) { return default; }
	///<summary>GetLODCount</summary>
	public static int GetLODCount(USkeletalMesh SkeletalMesh) { return default; }
	///<summary>ImportLOD</summary>
	public static int ImportLOD(USkeletalMesh BaseMesh,int LODIndex,string SourceFilename) { return default; }
	///<summary>ReimportAllCustomLODs</summary>
	public static bool ReimportAllCustomLODs(USkeletalMesh SkeletalMesh) { return default; }
	///<summary>GetLodBuildSettings</summary>
	public static void GetLodBuildSettings(USkeletalMesh SkeletalMesh,int LodIndex,FSkeletalMeshBuildSettings OutBuildOptions) {}
	///<summary>SetLodBuildSettings</summary>
	public static void SetLodBuildSettings(USkeletalMesh SkeletalMesh,int LodIndex,FSkeletalMeshBuildSettings BuildOptions) {}
	///<summary>Remove all the specified LODs. This function will remove all the valid LODs in the list.</summary>
	public static bool RemoveLODs(USkeletalMesh SkeletalMesh,TArray<int> ToRemoveLODs) { return default; }
	///<summary>This function will strip all triangle in the specified LOD that don&#39;t have any UV area pointing on a black pixel in the TextureMask.</summary>
	public static bool StripLODGeometry(USkeletalMesh SkeletalMesh,int LODIndex,UTexture2D TextureMask,float Threshold) { return default; }
	///<summary>This function creates a PhysicsAsset for the given SkeletalMesh with the same settings as if it were created through FBX import</summary>
	public static UPhysicsAsset CreatePhysicsAsset(USkeletalMesh SkeletalMesh) { return default; }
}
