#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepOperationsLibrary.h")]
public partial class UDataprepOperationsLibrary : UBlueprintFunctionLibrary {
// DataprepOperationsLibrary
	public static void SetLods(TArray<UObject> SelectedObjects,FStaticMeshReductionOptions ReductionOptions,TArray<UObject> ModifiedObjects) {}
	public static void SetSimpleCollision(TArray<UObject> SelectedObjects,EScriptCollisionShapeType ShapeType,TArray<UObject> ModifiedObjects) {}
	public static void SetConvexDecompositionCollision(TArray<UObject> SelectedObjects,int HullCount,int MaxHullVerts,int HullPrecision,TArray<UObject> ModifiedObjects) {}
	public static void SubstituteMaterial(TArray<UObject> SelectedObjects,string MaterialSearch,EEditorScriptingStringMatchType StringMatch,UMaterialInterface MaterialSubstitute) {}
	public static void SubstituteMaterialsByTable(TArray<UObject> SelectedObjects,UDataTable DataTable) {}
	public static void SetLODGroup(TArray<UObject> SelectedObjects,string LODGroupName,TArray<UObject> ModifiedObjects) {}
	public static void SetMaterial(TArray<UObject> SelectedObjects,UMaterialInterface MaterialSubstitute) {}
	public static void SetMobility(TArray<UObject> SelectedObjects,EComponentMobility MobilityType) {}
	public static void SetMesh(TArray<UObject> SelectedObjects,UStaticMesh MeshSubstitute) {}
	public static void SubstituteMesh(TArray<UObject> SelectedObjects,string MeshSearch,EEditorScriptingStringMatchType StringMatch,UStaticMesh MeshSubstitute) {}
	public static void SubstituteMeshesByTable(TArray<UObject> SelectedObjects,UDataTable DataTable) {}
	public static void AddTags(TArray<UObject> SelectedObjects,TArray<string> InTags) {}
	public static void AddMetadata(TArray<UObject> SelectedObjects,TMap<string,string> InMetadata) {}
	public static void ConsolidateObjects(TArray<UObject> SelectedObjects) {}
	public static void RandomizeTransform(TArray<UObject> SelectedObjects,ERandomizeTransformType TransformType,ERandomizeTransformReferenceFrame ReferenceFrame,FVector Min,FVector Max) {}
	public static void FlipFaces(TSet<UStaticMesh> StaticMeshes) {}
	public static void SetSubOuputLevel(TArray<UObject> SelectedObjects,string SubLevelName) {}
	public static void SetSubOuputFolder(TArray<UObject> SelectedObjects,string SubFolderName) {}
	public static void AddToLayer(TArray<UObject> SelectedObjects,string LayerName) {}
	public static void SetCollisionComplexity(TArray<UObject> InSelectedObjects,ECollisionTraceFlag InCollisionTraceFlag,TArray<UObject> InModifiedObjects) {}
	public static void ResizeTextures(TArray<UTexture2D> InTextures,int InMaxSize) {}
	public static void SetNaniteSettings(TArray<UObject> InSelectedObjects,bool bInEnabled,int InPositionPrecision,float InPercentTriangles,TArray<UObject> OutModifiedObjects) {}
}
