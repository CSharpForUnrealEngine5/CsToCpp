namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A UDataprepAssetProducers is a utility class to manage the set of producers constituting</summary>
[CppInclude("DataprepAssetProducers.h")]
public partial class UDataprepAssetProducers : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>List of producers referenced by the asset</summary>
	public TArray<FDataprepAssetProducer> AssetProducers;
	///<summary>List of producers referenced by the asset</summary>
	public int Padding;
}
