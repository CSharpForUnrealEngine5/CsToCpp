namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepOperationsLibrary.h")]
public partial class UDataprepOperationsLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Generate LODs on the static meshes contained in the input array</summary>
	public static void SetLods(TArray<UObject> SelectedObjects,FStaticMeshReductionOptions ReductionOptions,TArray<UObject> ModifiedObjects) {}
	///<summary>Set one simple collision of the given shape type on the static meshes contained in the</summary>
	public static void SetSimpleCollision(TArray<UObject> SelectedObjects,EScriptCollisionShapeType ShapeType,TArray<UObject> ModifiedObjects) {}
	///<summary>Add complex collision on the static meshes contained in the input array</summary>
	public static void SetConvexDecompositionCollision(TArray<UObject> SelectedObjects,int HullCount,int MaxHullVerts,int HullPrecision,TArray<UObject> ModifiedObjects) {}
	///<summary>Replaces designated materials in all or specific content folders with specific ones</summary>
	public static void SubstituteMaterial(TArray<UObject> SelectedObjects,string MaterialSearch,EEditorScriptingStringMatchType StringMatch,UMaterialInterface MaterialSubstitute) {}
	///<summary>Replaces designated materials in all or specific content folders with requested ones</summary>
	public static void SubstituteMaterialsByTable(TArray<UObject> SelectedObjects,UDataTable DataTable) {}
	///<summary>Remove inputs content</summary>
	public static void SetLODGroup(TArray<UObject> SelectedObjects,FName LODGroupName,TArray<UObject> ModifiedObjects) {}
	///<summary>Set the material to all elements of a set of Static Meshes or Static Mesh Actors</summary>
	public static void SetMaterial(TArray<UObject> SelectedObjects,UMaterialInterface MaterialSubstitute) {}
	///<summary>Set mobility on a set of static mesh actors</summary>
	public static void SetMobility(TArray<UObject> SelectedObjects,EComponentMobility MobilityType) {}
	///<summary>Set the mesh to all elements of a set of Actors containing StaticMeshComponents</summary>
	public static void SetMesh(TArray<UObject> SelectedObjects,UStaticMesh MeshSubstitute) {}
	///<summary>Replaces designated meshes in all or specific content folders with specific ones</summary>
	public static void SubstituteMesh(TArray<UObject> SelectedObjects,string MeshSearch,EEditorScriptingStringMatchType StringMatch,UStaticMesh MeshSubstitute) {}
	///<summary>Replaces designated meshes in all or specific content folders with requested ones</summary>
	public static void SubstituteMeshesByTable(TArray<UObject> SelectedObjects,UDataTable DataTable) {}
	///<summary>Add tags to a set of actors</summary>
	public static void AddTags(TArray<UObject> SelectedObjects,TArray<FName> InTags) {}
	///<summary>Adds metadata to selected objects that implement the UInterface_AssetUserData interface.</summary>
	public static void AddMetadata(TArray<UObject> SelectedObjects,TMap<FName,string> InMetadata) {}
	///<summary>Replace all references to the assets in the array, except the first, with the first asset of the array.</summary>
	public static void ConsolidateObjects(TArray<UObject> SelectedObjects) {}
	///<summary>Alters transform of selected objects by appling randomly generated offset to one of the transform components (rotation, scale or translation)</summary>
	public static void RandomizeTransform(TArray<UObject> SelectedObjects,ERandomizeTransformType TransformType,ERandomizeTransformReferenceFrame ReferenceFrame,FVector Min,FVector Max) {}
	///<summary>Flip the faces of all elements of a set of Static Meshes or Static Mesh Actors</summary>
	public static void FlipFaces(TSet<UStaticMesh> StaticMeshes) {}
	///<summary>Add/Edit UDataprepConsumerUserData with the requested name for the sub-level</summary>
	public static void SetSubOuputLevel(TArray<UObject> SelectedObjects,string SubLevelName) {}
	///<summary>Add/Edit UDataprepConsumerUserData with the requested name for the sub-folder</summary>
	public static void SetSubOuputFolder(TArray<UObject> SelectedObjects,string SubFolderName) {}
	///<summary>Add all Actors to a given layer.</summary>
	public static void AddToLayer(TArray<UObject> SelectedObjects,FName LayerName) {}
	///<summary>Set collision complexity for selected meshes</summary>
	public static void SetCollisionComplexity(TArray<UObject> InSelectedObjects,ECollisionTraceFlag InCollisionTraceFlag,TArray<UObject> InModifiedObjects) {}
	///<summary>Resize textures to max width/height and optionally ensure power of two size.</summary>
	public static void ResizeTextures(TArray<UTexture2D> InTextures,int InMaxSize) {}
	///<summary>Set Nanite settings for selected meshes</summary>
	public static void SetNaniteSettings(TArray<UObject> InSelectedObjects,bool bInEnabled,int InPositionPrecision,float InPercentTriangles,TArray<UObject> OutModifiedObjects) {}
}
