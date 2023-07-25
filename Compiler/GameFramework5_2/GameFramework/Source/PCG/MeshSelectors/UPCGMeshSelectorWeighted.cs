#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSelectors/PCGMeshSelectorWeighted.h")]
public partial class UPCGMeshSelectorWeighted : UPCGMeshSelectorBase {
// PCGMeshSelectorWeighted
	public TArray<FPCGMeshSelectorWeightedEntry> MeshEntries;
	public bool bUseAttributeMaterialOverrides;
	public TArray<string> MaterialOverrideAttributes;
}
