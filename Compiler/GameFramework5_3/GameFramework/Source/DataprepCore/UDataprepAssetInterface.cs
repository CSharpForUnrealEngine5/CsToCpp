namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepAssetInterface.h")]
public partial class UDataprepAssetInterface : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Recipe associated to the Dataprep asset</summary>
	public UDataprepRecipeInterface Recipe;
	///<summary>Producers associated to the Dataprep asset</summary>
	public UDataprepAssetProducers Inputs;
	///<summary>Consumer associated to the Dataprep asset</summary>
	public UDataprepContentConsumer Output;
}
