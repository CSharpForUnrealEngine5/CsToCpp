#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFeatureAction_DataRegistry.h")]
///<summary>Specifies a list of Data Registries to load and initialize with this feature</summary>
public partial class UGameFeatureAction_DataRegistry : UGameFeatureAction {
// GameFeatureAction_DataRegistry
	public TArray<TSoftObjectPtr<UDataRegistry>> RegistriesToAdd;
	public bool bPreloadInEditor;
}
