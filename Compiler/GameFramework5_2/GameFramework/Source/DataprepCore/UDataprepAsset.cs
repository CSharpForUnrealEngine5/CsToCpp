#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepAsset.h")]
///<summary>A DataprepAsset is an implementation of the DataprepAssetInterface using</summary>
public partial class UDataprepAsset : UDataprepAssetInterface {
// DataprepAsset
	public UBlueprint DataprepRecipeBP_DEPRECATED;
	public TArray<FDataprepAssetProducer> Producers_DEPRECATED;
	public UDataprepContentConsumer Consumer_DEPRECATED;
	public UEdGraphNode StartNode_DEPRECATED;
	public UDataprepParameterization Parameterization;
	public TArray<UDataprepActionAsset> ActionAssets;
}
