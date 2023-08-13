namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSelectors/PCGMeshSelectorWeightedByCategory.h")]
public partial class UPCGMeshSelectorWeightedByCategory : UPCGMeshSelectorBase {
	public static UClass StaticClass() {return default;}
	///<summary>CategoryAttribute</summary>
	public string CategoryAttribute;
	///<summary>Entries</summary>
	public TArray<FPCGWeightedByCategoryEntryList> Entries;
	///<summary>bUseAttributeMaterialOverrides</summary>
	public bool bUseAttributeMaterialOverrides;
	///<summary>MaterialOverrideAttributes</summary>
	public TArray<string> MaterialOverrideAttributes;
}
