#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A UDataprepAssetProducers is a utility class to manage the set of producers constituting</summary>
[CppInclude("DataprepAssetProducers.h")]
public partial class UDataprepAssetProducers : UObject {
	///<summary>List of producers referenced by the asset</summary>
	public TArray<FDataprepAssetProducer> AssetProducers;
	///<summary>List of producers referenced by the asset</summary>
	public int Padding;
}
