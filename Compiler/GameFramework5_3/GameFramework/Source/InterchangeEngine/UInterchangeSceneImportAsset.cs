namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Class to hold all the data required to properly re-import a level</summary>
[CppInclude("InterchangeSceneImportAsset.h")]
public partial class UInterchangeSceneImportAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Importing data and options used for this Datasmith scene</summary>
	public UInterchangeAssetImportData AssetImportData;
	///<summary>Array of user data stored with the asset</summary>
	public TArray<UAssetUserData> AssetUserData;
}
