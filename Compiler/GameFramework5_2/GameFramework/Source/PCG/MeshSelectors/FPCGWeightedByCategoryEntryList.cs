#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSelectors/PCGMeshSelectorWeightedByCategory.h")]
public partial struct FPCGWeightedByCategoryEntryList {
	public string CategoryEntry;
	public bool IsDefault;
	public TArray<FPCGMeshSelectorWeightedEntry> WeightedMeshEntries;
}
