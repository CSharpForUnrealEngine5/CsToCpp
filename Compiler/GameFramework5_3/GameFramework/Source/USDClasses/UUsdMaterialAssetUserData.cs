namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>AssetImportData assigned to Unreal materials that are generated when parsing USD Material prims</summary>
[CppInclude("USDAssetUserData.h")]
public partial class UUsdMaterialAssetUserData : UUsdAssetUserData {
	public static UClass StaticClass() {return default;}
	///<summary>In the context of our reference materials that just read a single texture for each material parameter, this</summary>
	public TMap<string,string> ParameterToPrimvar;
	///<summary>In the context of our reference materials that just read a single texture for each material parameter, this</summary>
	public TMap<string,int> PrimvarToUVIndex;
}
