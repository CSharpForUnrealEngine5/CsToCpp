#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Specifies a list of Data Registries to load and initialize with this feature</summary>
[CppInclude("GameFeatureAction_DataRegistry.h")]
public partial class UGameFeatureAction_DataRegistry : UGameFeatureAction {
	public static UClass StaticClass() {return default;}
	///<summary>List of registry assets to load and initialize</summary>
	public TArray<TSoftObjectPtr<UDataRegistry>> RegistriesToAdd;
	///<summary>If true, this will preload the registries when the feature is registered in the editor to support the editor pickers</summary>
	public bool bPreloadInEditor;
}
