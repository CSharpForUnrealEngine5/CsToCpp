#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint library for altering and analyzing animation / skeletal data</summary>
[CppInclude("EditorTestsUtilityLibrary.h")]
public partial class UEditorTestsUtilityLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Bakes out material in-place for the given set of static mesh components using the MaterialMergeOptions</summary>
	public static void BakeMaterialsForComponent(UStaticMeshComponent InStaticMeshComponent,UMaterialOptions MaterialOptions,UMaterialMergeOptions MaterialMergeOptions) {}
	///<summary>Merges meshes and bakes out materials into a atlas-material for the given set of static mesh components using the MergeSettings</summary>
	public static void MergeStaticMeshComponents(TArray<UStaticMeshComponent> InStaticMeshComponents,FMeshMergingSettings MergeSettings,bool bReplaceActors,TArray<int> OutLODIndices) {}
}
