#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A seed file that is created to mark referenced assets as part of this primary asset</summary>
[CppInclude("Engine/PrimaryAssetLabel.h")]
public partial class UPrimaryAssetLabel : UPrimaryDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Management rules for this specific asset, if set it will override the type rules</summary>
	public FPrimaryAssetRules Rules;
	///<summary>True to Label everything in this directory and sub directories</summary>
	public bool bLabelAssetsInMyDirectory;
	///<summary>Set to true if the label asset itself should be cooked and available at runtime. This does not affect the assets that are labeled, they are set with cook rule</summary>
	public bool bIsRuntimeLabel;
	///<summary>List of manually specified assets to label</summary>
	public TArray<TSoftObjectPtr<UObject>> ExplicitAssets;
	///<summary>List of manually specified blueprint assets to label</summary>
	public TArray<TSoftObjectPtr<UClass>> ExplicitBlueprints;
	///<summary>Collection to load asset references out of</summary>
	public FCollectionReference AssetCollection;
}
