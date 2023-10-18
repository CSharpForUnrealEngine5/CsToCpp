namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSelectors/PCGMeshSelectorWeightedByCategory.h")]
public partial struct FPCGWeightedByCategoryEntryList {
	public string CategoryEntry;
	public bool IsDefault;
	public TArray<FPCGMeshSelectorWeightedEntry> WeightedMeshEntries;
}
