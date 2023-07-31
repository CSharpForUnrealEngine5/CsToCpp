#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSelectors/PCGMeshSelectorWeightedByCategory.h")]
public partial class UPCGMeshSelectorWeightedByCategory : UPCGMeshSelectorBase {
	///<summary>CategoryAttribute</summary>
	public string CategoryAttribute;
	///<summary>Entries</summary>
	public TArray<FPCGWeightedByCategoryEntryList> Entries;
	///<summary>bUseAttributeMaterialOverrides</summary>
	public bool bUseAttributeMaterialOverrides;
	///<summary>MaterialOverrideAttributes</summary>
	public TArray<string> MaterialOverrideAttributes;
}
