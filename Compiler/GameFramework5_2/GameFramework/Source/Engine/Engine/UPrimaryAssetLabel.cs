#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PrimaryAssetLabel.h")]
///<summary>A seed file that is created to mark referenced assets as part of this primary asset</summary>
public partial class UPrimaryAssetLabel : UPrimaryDataAsset {
// PrimaryAssetLabel
	public FPrimaryAssetRules Rules;
	public bool bLabelAssetsInMyDirectory;
	public bool bIsRuntimeLabel;
	public TArray<TSoftObjectPtr<UObject>> ExplicitAssets;
	public TArray<TSoftObjectPtr<UClass>> ExplicitBlueprints;
	public FCollectionReference AssetCollection;
}
