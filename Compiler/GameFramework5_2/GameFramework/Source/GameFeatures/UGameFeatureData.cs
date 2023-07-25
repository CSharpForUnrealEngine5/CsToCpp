#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFeatureData.h")]
///<summary>Data related to a game feature, a collection of code and content that adds a separable discrete feature to the game</summary>
public partial class UGameFeatureData : UPrimaryDataAsset {
// GameFeatureData
	public TArray<UGameFeatureAction> Actions;
	public TArray<FPrimaryAssetTypeInfo> PrimaryAssetTypesToScan;
}
