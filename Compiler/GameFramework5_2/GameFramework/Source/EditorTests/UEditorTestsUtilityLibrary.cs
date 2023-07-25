#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorTestsUtilityLibrary.h")]
///<summary>Blueprint library for altering and analyzing animation / skeletal data</summary>
public partial class UEditorTestsUtilityLibrary : UBlueprintFunctionLibrary {
// EditorTestsUtilityLibrary
	public void BakeMaterialsForComponent(UObject InStaticMeshComponent,UObject MaterialOptions,UObject MaterialMergeOptions) {}
	public void MergeStaticMeshComponents(TArray<UObject> InStaticMeshComponents,FMeshMergingSettings MergeSettings,bool bReplaceActors,TArray<int> OutLODIndices) {}
}
