#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An asset holding the data needed to generate/update/animate a RigLogic character</summary>
[CppInclude("DNAAsset.h")]
public partial class UDNAAsset : UAssetUserData {
	public static UClass StaticClass() {return default;}
	///<summary>AssetImportData</summary>
	public UAssetImportData AssetImportData;
	///<summary>DnaFileName</summary>
	public string DnaFileName;
}
