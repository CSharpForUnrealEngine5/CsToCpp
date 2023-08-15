namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSelectors/PCGMeshSelectorWeighted.h")]
public partial class UPCGMeshSelectorWeighted : UPCGMeshSelectorBase {
	public static UClass StaticClass() {return default;}
	///<summary>MeshEntries</summary>
	public TArray<FPCGMeshSelectorWeightedEntry> MeshEntries;
	///<summary>bUseAttributeMaterialOverrides</summary>
	public bool bUseAttributeMaterialOverrides;
	///<summary>MaterialOverrideAttributes</summary>
	public TArray<FName> MaterialOverrideAttributes;
}
