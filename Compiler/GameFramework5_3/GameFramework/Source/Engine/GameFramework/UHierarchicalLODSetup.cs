namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/WorldSettings.h")]
public partial class UHierarchicalLODSetup : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Hierarchical LOD Setup</summary>
	public TArray<FHierarchicalSimplification> HierarchicalLODSetup;
	///<summary>OverrideBaseMaterial</summary>
	public TSoftObjectPtr<UMaterialInterface> OverrideBaseMaterial;
}
