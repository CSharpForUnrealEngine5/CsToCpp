#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFeatureAction_DataRegistrySource.h")]
///<summary>Specifies a list of source assets to add to Data Registries when this feature is activated</summary>
public partial class UGameFeatureAction_DataRegistrySource : UGameFeatureAction {
// GameFeatureAction_DataRegistrySource
	public TArray<FDataRegistrySourceToAdd> SourcesToAdd;
	public bool bPreloadInEditor;
}
