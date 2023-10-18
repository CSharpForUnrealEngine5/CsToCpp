namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data related to a game feature, a collection of code and content that adds a separable discrete feature to the game</summary>
[CppInclude("GameFeatureData.h")]
public partial class UGameFeatureData : UPrimaryDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>GetPluginName</summary>
	public static void GetPluginName(UGameFeatureData GFD,string PluginName) {}
	///<summary>List of actions to perform as this game feature is loaded/activated/deactivated/unloaded</summary>
	public TArray<UGameFeatureAction> Actions;
	///<summary>List of asset types to scan at startup</summary>
	public TArray<FPrimaryAssetTypeInfo> PrimaryAssetTypesToScan;
}
