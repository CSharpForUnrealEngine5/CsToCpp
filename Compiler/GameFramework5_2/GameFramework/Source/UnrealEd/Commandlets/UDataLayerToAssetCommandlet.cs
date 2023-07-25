#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Commandlets/WorldPartitionDataLayerToAssetCommandLet.h")]
public partial class UDataLayerToAssetCommandlet : UCommandlet {
// DataLayerToAssetCommandlet
	public string DestinationFolder;
	public string ConversionFolder;
	public bool bPerformSavePackages;
	public bool bIgnoreActorLoadingErrors;
	public UDataLayerFactory DataLayerFactory;
	public UWorld MainWorld;
}
