namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Utility class to hold on FAssetData entities while their associated texture is being built</summary>
[CppInclude("DatasmithRuntimeAuxiliaryData.h")]
public partial class UDatasmithRuntimeTHelper : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Array of user data stored with the asset</summary>
	public TArray<UAssetUserData> AssetUserData;
}
