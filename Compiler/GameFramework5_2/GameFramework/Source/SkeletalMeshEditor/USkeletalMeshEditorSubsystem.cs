#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USkeletalMeshEditorSubsystem</summary>
[CppInclude("SkeletalMeshEditorSubsystem.h")]
public partial class USkeletalMeshEditorSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Regenerate LODs of the mesh</summary>
	public static bool RegenerateLOD(USkeletalMesh SkeletalMesh,int NewLODCount/*=0*/,bool bRegenerateEvenIfImported/*=false*/,bool bGenerateBaseLOD/*=false*/) { return default; }
	///<summary>Get number of mesh vertices for an LOD of a Skeletal Mesh</summary>
	public  int GetNumVerts(USkeletalMesh SkeletalMesh,int LODIndex) { return default; }
	///<summary>Get number of sections for a LOD of a Skeletal Mesh</summary>
	public  int GetNumSections(USkeletalMesh SkeletalMesh,int LODIndex) { return default; }
	///<summary>Get bRecomputeTangent from a section of a LOD of a Skeletal Mesh</summary>
	public  bool GetSectionRecomputeTangent(USkeletalMesh SkeletalMesh,int LODIndex,int SectionIndex,bool bOutRecomputeTangent) { return default; }
	///<summary>Set bRecomputeTangent for a section of a LOD of a Skeletal Mesh.</summary>
	public  bool SetSectionRecomputeTangent(USkeletalMesh SkeletalMesh,int LODIndex,int SectionIndex,bool bRecomputeTangent) { return default; }
	///<summary>Get RecomputeTangentsVertexMaskChannel from a section of a LOD of a Skeletal Mesh</summary>
	public  bool GetSectionRecomputeTangentsVertexMaskChannel(USkeletalMesh SkeletalMesh,int LODIndex,int SectionIndex,byte OutRecomputeTangentsVertexMaskChannel) { return default; }
	///<summary>Set RecomputeTangentsVertexMaskChannel for a section of a LOD of a Skeletal Mesh.</summary>
	public  bool SetSectionRecomputeTangentsVertexMaskChannel(USkeletalMesh SkeletalMesh,int LODIndex,int SectionIndex,byte RecomputeTangentsVertexMaskChannel) { return default; }
	///<summary>Get bCastShadow from a section of a LOD of a Skeletal Mesh</summary>
	public  bool GetSectionCastShadow(USkeletalMesh SkeletalMesh,int LODIndex,int SectionIndex,bool bOutCastShadow) { return default; }
	///<summary>Set bCastShadow for a section of a LOD of a Skeletal Mesh.</summary>
	public  bool SetSectionCastShadow(USkeletalMesh SkeletalMesh,int LODIndex,int SectionIndex,bool bCastShadow) { return default; }
	///<summary>Get bVisibleInRayTracing from a section of a LOD of a Skeletal Mesh</summary>
	public  bool GetSectionVisibleInRayTracing(USkeletalMesh SkeletalMesh,int LODIndex,int SectionIndex,bool bOutVisibleInRayTracing) { return default; }
	///<summary>Set bVisibleInRayTracing for a section of a LOD of a Skeletal Mesh.</summary>
	public  bool SetSectionVisibleInRayTracing(USkeletalMesh SkeletalMesh,int LODIndex,int SectionIndex,bool bVisibleInRayTracing) { return default; }
	///<summary>Gets the material slot used for a specific LOD section.</summary>
	public  int GetLODMaterialSlot(USkeletalMesh SkeletalMesh,int LODIndex,int SectionIndex) { return default; }
	///<summary>Rename a socket within a skeleton</summary>
	public static bool RenameSocket(USkeletalMesh SkeletalMesh,string OldName,string NewName) { return default; }
	///<summary>Retrieve the number of LOD contain in the specified skeletal mesh.</summary>
	public static int GetLODCount(USkeletalMesh SkeletalMesh) { return default; }
	///<summary>Import or re-import a LOD into the specified base mesh. If the LOD do not exist it will import it and add it to the base static mesh. If the LOD already exist it will re-import the specified LOD.</summary>
	public static int ImportLOD(USkeletalMesh BaseMesh,int LODIndex,string SourceFilename) { return default; }
	///<summary>Re-import the specified skeletal mesh and all the custom LODs.</summary>
	public static bool ReimportAllCustomLODs(USkeletalMesh SkeletalMesh) { return default; }
	///<summary>Copy the build options with the specified LOD build settings.</summary>
	public static void GetLodBuildSettings(USkeletalMesh SkeletalMesh,int LodIndex,FSkeletalMeshBuildSettings OutBuildOptions) {}
	///<summary>Set the LOD build options for the specified LOD index.</summary>
	public static void SetLodBuildSettings(USkeletalMesh SkeletalMesh,int LodIndex,FSkeletalMeshBuildSettings BuildOptions) {}
	///<summary>This function creates a PhysicsAsset for the given SkeletalMesh with the same settings as if it were created through FBX import</summary>
	public static UPhysicsAsset CreatePhysicsAsset(USkeletalMesh SkeletalMesh) { return default; }
}
