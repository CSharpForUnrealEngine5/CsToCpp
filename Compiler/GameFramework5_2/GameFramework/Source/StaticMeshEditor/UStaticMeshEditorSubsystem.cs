#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UStaticMeshEditorSubsystem</summary>
[CppInclude("StaticMeshEditorSubsystem.h")]
public partial class UStaticMeshEditorSubsystem : UEditorSubsystem {
	///<summary>Remove then add LODs on a static mesh.</summary>
	public  int SetLodsWithNotification(UStaticMesh StaticMesh,FStaticMeshReductionOptions ReductionOptions,bool bApplyChanges) { return default; }
	///<summary>Same as SetLodsWithNotification but changes are applied.</summary>
	public  int SetLods(UStaticMesh StaticMesh,FStaticMeshReductionOptions ReductionOptions) { return default; }
	///<summary>Copy the reduction options with the specified LOD reduction settings.</summary>
	public  void GetLodReductionSettings(UStaticMesh StaticMesh,int LodIndex,FMeshReductionSettings OutReductionOptions) {}
	///<summary>Set the LOD reduction for the specified LOD index.</summary>
	public  void SetLodReductionSettings(UStaticMesh StaticMesh,int LodIndex,FMeshReductionSettings ReductionOptions) {}
	///<summary>Copy the build options with the specified LOD build settings.</summary>
	public  void GetLodBuildSettings(UStaticMesh StaticMesh,int LodIndex,FMeshBuildSettings OutBuildOptions) {}
	///<summary>Set the LOD build options for the specified LOD index.</summary>
	public  void SetLodBuildSettings(UStaticMesh StaticMesh,int LodIndex,FMeshBuildSettings BuildOptions) {}
	///<summary>Get the LODGroup for the specified static mesh</summary>
	public  string GetLODGroup(UStaticMesh StaticMesh) { return default; }
	///<summary>Set the LODGroup for the specified static mesh</summary>
	public  bool SetLODGroup(UStaticMesh StaticMesh,string LODGroup,bool bRebuildImmediately/*=true*/) { return default; }
	///<summary>Import or re-import a LOD into the specified base mesh. If the LOD do not exist it will import it and add it to the base static mesh. If the LOD already exist it will re-import the specified LOD.</summary>
	public  int ImportLOD(UStaticMesh BaseStaticMesh,int LODIndex,string SourceFilename) { return default; }
	///<summary>Re-import all the custom LODs present in the specified static mesh.</summary>
	public  bool ReimportAllCustomLODs(UStaticMesh StaticMesh) { return default; }
	///<summary>Adds or create a LOD at DestinationLodIndex using the geometry from SourceStaticMesh SourceLodIndex</summary>
	public  int SetLodFromStaticMesh(UStaticMesh DestinationStaticMesh,int DestinationLodIndex,UStaticMesh SourceStaticMesh,int SourceLodIndex,bool bReuseExistingMaterialSlots) { return default; }
	///<summary>Get number of LODs present on a static mesh.</summary>
	public  int GetLodCount(UStaticMesh StaticMesh) { return default; }
	///<summary>Remove LODs on a static mesh except LOD 0.</summary>
	public  bool RemoveLods(UStaticMesh StaticMesh) { return default; }
	///<summary>Get an array of LOD screen sizes for evaluation.</summary>
	public  TArray<float> GetLodScreenSizes(UStaticMesh StaticMesh) { return default; }
	///<summary>Set LOD screen sizes.</summary>
	public  bool SetLodScreenSizes(UStaticMesh StaticMesh,TArray<float> ScreenSizes) { return default; }
	///<summary>Get the Nanite Settings for the mesh</summary>
	public  FMeshNaniteSettings GetNaniteSettings(UStaticMesh StaticMesh) { return default; }
	///<summary>Get the Nanite Settings for the mesh</summary>
	public  void SetNaniteSettings(UStaticMesh StaticMesh,FMeshNaniteSettings NaniteSettings,bool bApplyChanges/*=true*/) {}
	///<summary>Add simple collisions to a static mesh.</summary>
	public  int AddSimpleCollisionsWithNotification(UStaticMesh StaticMesh,EScriptCollisionShapeType ShapeType,bool bApplyChanges) { return default; }
	///<summary>Same as AddSimpleCollisionsWithNotification but changes are automatically applied.</summary>
	public  int AddSimpleCollisions(UStaticMesh StaticMesh,EScriptCollisionShapeType ShapeType) { return default; }
	///<summary>Get number of simple collisions present on a static mesh.</summary>
	public  int GetSimpleCollisionCount(UStaticMesh StaticMesh) { return default; }
	///<summary>Get the Collision Trace behavior of a static mesh</summary>
	public  ECollisionTraceFlag GetCollisionComplexity(UStaticMesh StaticMesh) { return default; }
	///<summary>Get number of convex collisions present on a static mesh.</summary>
	public  int GetConvexCollisionCount(UStaticMesh StaticMesh) { return default; }
	///<summary>Add a convex collision to a static mesh.</summary>
	public  bool SetConvexDecompositionCollisionsWithNotification(UStaticMesh StaticMesh,int HullCount,int MaxHullVerts,int HullPrecision,bool bApplyChanges) { return default; }
	///<summary>Compute convex collisions for a set of static meshes.</summary>
	public  bool BulkSetConvexDecompositionCollisionsWithNotification(TArray<UStaticMesh> StaticMeshes,int HullCount,int MaxHullVerts,int HullPrecision,bool bApplyChanges) { return default; }
	///<summary>Same as SetConvexDecompositionCollisionsWithNotification but changes are automatically applied.</summary>
	public  bool SetConvexDecompositionCollisions(UStaticMesh StaticMesh,int HullCount,int MaxHullVerts,int HullPrecision) { return default; }
	///<summary>Same as SetConvexDecompositionCollisionsWithNotification but changes are automatically applied.</summary>
	public  bool BulkSetConvexDecompositionCollisions(TArray<UStaticMesh> StaticMeshes,int HullCount,int MaxHullVerts,int HullPrecision) { return default; }
	///<summary>Remove collisions from a static mesh.</summary>
	public  bool RemoveCollisionsWithNotification(UStaticMesh StaticMesh,bool bApplyChanges) { return default; }
	///<summary>Same as RemoveCollisionsWithNotification but changes are applied.</summary>
	public  bool RemoveCollisions(UStaticMesh StaticMesh) { return default; }
	///<summary>Enables/disables mesh section collision for a specific LOD.</summary>
	public  void EnableSectionCollision(UStaticMesh StaticMesh,bool bCollisionEnabled,int LODIndex,int SectionIndex) {}
	///<summary>Checks if a specific LOD mesh section has collision.</summary>
	public  bool IsSectionCollisionEnabled(UStaticMesh StaticMesh,int LODIndex,int SectionIndex) { return default; }
	///<summary>Enables/disables mesh section shadow casting for a specific LOD.</summary>
	public  void EnableSectionCastShadow(UStaticMesh StaticMesh,bool bCastShadow,int LODIndex,int SectionIndex) {}
	///<summary>Sets the material slot for a specific LOD.</summary>
	public  void SetLODMaterialSlot(UStaticMesh StaticMesh,int MaterialSlotIndex,int LODIndex,int SectionIndex) {}
	///<summary>Gets the material slot used for a specific LOD section.</summary>
	public  int GetLODMaterialSlot(UStaticMesh StaticMesh,int LODIndex,int SectionIndex) { return default; }
	///<summary>Check whether a static mesh has vertex colors</summary>
	public  bool HasVertexColors(UStaticMesh StaticMesh) { return default; }
	///<summary>Check whether a static mesh component has vertex colors</summary>
	public  bool HasInstanceVertexColors(UStaticMeshComponent StaticMeshComponent) { return default; }
	///<summary>Set Generate Lightmap UVs for StaticMesh</summary>
	public  bool SetGenerateLightmapUVs(UStaticMesh StaticMesh,bool bGenerateLightmapUVs) { return default; }
	///<summary>Get number of StaticMesh verts for an LOD</summary>
	public  int GetNumberVerts(UStaticMesh StaticMesh,int LODIndex) { return default; }
	///<summary>Get number of Materials for a StaticMesh</summary>
	public  int GetNumberMaterials(UStaticMesh StaticMesh) { return default; }
	///<summary>Sets StaticMeshFlag bAllowCPUAccess</summary>
	public  void SetAllowCPUAccess(UStaticMesh StaticMesh,bool bAllowCPUAccess) {}
	///<summary>Returns the number of UV channels for the given LOD of a StaticMesh.</summary>
	public  int GetNumUVChannels(UStaticMesh StaticMesh,int LODIndex) { return default; }
	///<summary>Adds an empty UV channel at the end of the existing channels on the given LOD of a StaticMesh.</summary>
	public  bool AddUVChannel(UStaticMesh StaticMesh,int LODIndex) { return default; }
	///<summary>Inserts an empty UV channel at the specified channel index on the given LOD of a StaticMesh.</summary>
	public  bool InsertUVChannel(UStaticMesh StaticMesh,int LODIndex,int UVChannelIndex) { return default; }
	///<summary>Removes the UV channel at the specified channel index on the given LOD of a StaticMesh.</summary>
	public  bool RemoveUVChannel(UStaticMesh StaticMesh,int LODIndex,int UVChannelIndex) { return default; }
	///<summary>Generates planar UV mapping in the specified UV channel on the given LOD of a StaticMesh.</summary>
	public  bool GeneratePlanarUVChannel(UStaticMesh StaticMesh,int LODIndex,int UVChannelIndex,FVector Position,FRotator Orientation,FVector2D Tiling) { return default; }
	///<summary>Generates cylindrical UV mapping in the specified UV channel on the given LOD of a StaticMesh.</summary>
	public  bool GenerateCylindricalUVChannel(UStaticMesh StaticMesh,int LODIndex,int UVChannelIndex,FVector Position,FRotator Orientation,FVector2D Tiling) { return default; }
	///<summary>Generates box UV mapping in the specified UV channel on the given LOD of a StaticMesh.</summary>
	public  bool GenerateBoxUVChannel(UStaticMesh StaticMesh,int LODIndex,int UVChannelIndex,FVector Position,FRotator Orientation,FVector Size) { return default; }
	///<summary>Find the references of the material MaterialToReplaced on all the MeshComponents provided and replace it by NewMaterial.</summary>
	public  void ReplaceMeshComponentsMaterials(TArray<UMeshComponent> MeshComponents,UMaterialInterface MaterialToBeReplaced,UMaterialInterface NewMaterial) {}
	///<summary>Find the references of the material MaterialToReplaced on all the MeshComponents of all the Actors provided and replace it by NewMaterial.</summary>
	public  void ReplaceMeshComponentsMaterialsOnActors(TArray<AActor> Actors,UMaterialInterface MaterialToBeReplaced,UMaterialInterface NewMaterial) {}
	///<summary>Find the references of the mesh MeshToBeReplaced on all the MeshComponents provided and replace it by NewMesh.</summary>
	public  void ReplaceMeshComponentsMeshes(TArray<UStaticMeshComponent> MeshComponents,UStaticMesh MeshToBeReplaced,UStaticMesh NewMesh) {}
	///<summary>Find the references of the mesh MeshToBeReplaced on all the MeshComponents of all the Actors provided and replace it by NewMesh.</summary>
	public  void ReplaceMeshComponentsMeshesOnActors(TArray<AActor> Actors,UStaticMesh MeshToBeReplaced,UStaticMesh NewMesh) {}
	///<summary>Create a new Actor in the level that contains a duplicate of all the Actors Static Meshes Component.</summary>
	public  AActor JoinStaticMeshActors(TArray<AStaticMeshActor> ActorsToJoin,FJoinStaticMeshActorsOptions JoinOptions) { return default; }
	///<summary>Merge the meshes into a unique mesh with the provided StaticMeshActors. There are multiple options on how to merge the meshes and their materials.</summary>
	public  bool MergeStaticMeshActors(TArray<AStaticMeshActor> ActorsToMerge,FMergeStaticMeshActorsOptions MergeOptions,AStaticMeshActor OutMergedActor) { return default; }
	///<summary>Build a proxy mesh actor that can replace a set of mesh actors.</summary>
	public  bool CreateProxyMeshActor(TArray<AStaticMeshActor> ActorsToMerge,FCreateProxyMeshActorOptions MergeOptions,AStaticMeshActor OutMergedActor) { return default; }
}
