#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepAssetInterface.h")]
public partial class UDataprepAssetInterface : UObject {
	///<summary>Recipe associated to the Dataprep asset</summary>
	public UDataprepRecipeInterface Recipe;
	///<summary>Producers associated to the Dataprep asset</summary>
	public UDataprepAssetProducers Inputs;
	///<summary>Consumer associated to the Dataprep asset</summary>
	public UDataprepContentConsumer Output;
}
