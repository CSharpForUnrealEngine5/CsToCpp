#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepOperationsLibrary.h")]
public partial class UDataprepOperationsLibrary : UBlueprintFunctionLibrary {
// DataprepOperationsLibrary
	public void SetLods(TArray<UObject> SelectedObjects,FStaticMeshReductionOptions ReductionOptions,TArray<UObject> ModifiedObjects) {}
	public void SetSimpleCollision(TArray<UObject> SelectedObjects,EScriptCollisionShapeType ShapeType,TArray<UObject> ModifiedObjects) {}
	public void SetConvexDecompositionCollision(TArray<UObject> SelectedObjects,int HullCount,int MaxHullVerts,int HullPrecision,TArray<UObject> ModifiedObjects) {}
	public void SubstituteMaterial(TArray<UObject> SelectedObjects,string MaterialSearch,EEditorScriptingStringMatchType StringMatch,UObject MaterialSubstitute) {}
	public void SubstituteMaterialsByTable(TArray<UObject> SelectedObjects,UObject DataTable) {}
	public void SetLODGroup(TArray<UObject> SelectedObjects,string LODGroupName,TArray<UObject> ModifiedObjects) {}
	public void SetMaterial(TArray<UObject> SelectedObjects,UObject MaterialSubstitute) {}
	public void SetMobility(TArray<UObject> SelectedObjects,EComponentMobility MobilityType) {}
	public void SetMesh(TArray<UObject> SelectedObjects,UObject MeshSubstitute) {}
	public void SubstituteMesh(TArray<UObject> SelectedObjects,string MeshSearch,EEditorScriptingStringMatchType StringMatch,UObject MeshSubstitute) {}
	public void SubstituteMeshesByTable(TArray<UObject> SelectedObjects,UObject DataTable) {}
	public void AddTags(TArray<UObject> SelectedObjects,TArray<string> InTags) {}
	public void AddMetadata(TArray<UObject> SelectedObjects,TMap<string,string> InMetadata) {}
	public void ConsolidateObjects(TArray<UObject> SelectedObjects) {}
	public void RandomizeTransform(TArray<UObject> SelectedObjects,ERandomizeTransformType TransformType,ERandomizeTransformReferenceFrame ReferenceFrame,FVector Min,FVector Max) {}
	public void FlipFaces(TSet<UObject> StaticMeshes) {}
	public void SetSubOuputLevel(TArray<UObject> SelectedObjects,string SubLevelName) {}
	public void SetSubOuputFolder(TArray<UObject> SelectedObjects,string SubFolderName) {}
	public void AddToLayer(TArray<UObject> SelectedObjects,string LayerName) {}
	public void SetCollisionComplexity(TArray<UObject> InSelectedObjects,ECollisionTraceFlag InCollisionTraceFlag,TArray<UObject> InModifiedObjects) {}
	public void ResizeTextures(TArray<UObject> InTextures,int InMaxSize) {}
	public void SetNaniteSettings(TArray<UObject> InSelectedObjects,bool bInEnabled,int InPositionPrecision,float InPercentTriangles,TArray<UObject> OutModifiedObjects) {}
}
