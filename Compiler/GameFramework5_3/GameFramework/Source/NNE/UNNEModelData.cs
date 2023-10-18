namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class represents assets that store neural network model data.</summary>
[CppInclude("NNEModelData.h")]
public partial class UNNEModelData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Importing data used for this asset.</summary>
	public UAssetImportData AssetImportData;
}
