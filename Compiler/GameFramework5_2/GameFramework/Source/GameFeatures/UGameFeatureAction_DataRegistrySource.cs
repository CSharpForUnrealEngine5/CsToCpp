namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Specifies a list of source assets to add to Data Registries when this feature is activated</summary>
[CppInclude("GameFeatureAction_DataRegistrySource.h")]
public partial class UGameFeatureAction_DataRegistrySource : UGameFeatureAction {
	public static UClass StaticClass() {return default;}
	///<summary>List of sources to add when this feature is activated</summary>
	public TArray<FDataRegistrySourceToAdd> SourcesToAdd;
	///<summary>If true, this will preload the sources when the feature is registered in the editor to support the editor pickers</summary>
	public bool bPreloadInEditor;
}
