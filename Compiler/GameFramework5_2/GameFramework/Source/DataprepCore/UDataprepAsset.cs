namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A DataprepAsset is an implementation of the DataprepAssetInterface using</summary>
[CppInclude("DataprepAsset.h")]
public partial class UDataprepAsset : UDataprepAssetInterface {
	public static UClass StaticClass() {return default;}
	///<summary>DEPRECATED: Pointer to data preparation pipeline blueprint previously used to process input data</summary>
	public UBlueprint DataprepRecipeBP_DEPRECATED;
	///<summary>DEPRECATED: List of producers referenced by the asset</summary>
	public TArray<FDataprepAssetProducer> Producers_DEPRECATED;
	///<summary>DEPRECATED: COnsumer referenced by the asset</summary>
	public UDataprepContentConsumer Consumer_DEPRECATED;
	///<summary>DEPRECATED: Pointer to the entry node of the pipeline blueprint previously used to process input data</summary>
	public UEdGraphNode StartNode_DEPRECATED;
	///<summary>Parameterization</summary>
	public UDataprepParameterization Parameterization;
	///<summary>ActionAssets</summary>
	public TArray<UDataprepActionAsset> ActionAssets;
}
