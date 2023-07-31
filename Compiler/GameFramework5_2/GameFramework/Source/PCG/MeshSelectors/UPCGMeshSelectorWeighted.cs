#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSelectors/PCGMeshSelectorWeighted.h")]
public partial class UPCGMeshSelectorWeighted : UPCGMeshSelectorBase {
	///<summary>MeshEntries</summary>
	public TArray<FPCGMeshSelectorWeightedEntry> MeshEntries;
	///<summary>bUseAttributeMaterialOverrides</summary>
	public bool bUseAttributeMaterialOverrides;
	///<summary>MaterialOverrideAttributes</summary>
	public TArray<string> MaterialOverrideAttributes;
}
