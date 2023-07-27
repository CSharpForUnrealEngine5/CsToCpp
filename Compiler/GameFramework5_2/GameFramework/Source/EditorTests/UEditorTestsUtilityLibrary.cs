#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorTestsUtilityLibrary.h")]
///<summary>Blueprint library for altering and analyzing animation / skeletal data</summary>
public partial class UEditorTestsUtilityLibrary : UBlueprintFunctionLibrary {
// EditorTestsUtilityLibrary
	public static void BakeMaterialsForComponent(UStaticMeshComponent InStaticMeshComponent,UMaterialOptions MaterialOptions,UMaterialMergeOptions MaterialMergeOptions) {}
	public static void MergeStaticMeshComponents(TArray<UStaticMeshComponent> InStaticMeshComponents,FMeshMergingSettings MergeSettings,bool bReplaceActors,TArray<int> OutLODIndices) {}
}
