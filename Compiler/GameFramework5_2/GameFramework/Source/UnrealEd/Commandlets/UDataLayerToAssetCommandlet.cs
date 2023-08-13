namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Commandlets/WorldPartitionDataLayerToAssetCommandLet.h")]
public partial class UDataLayerToAssetCommandlet : UCommandlet {
	public static UClass StaticClass() {return default;}
	///<summary>DestinationFolder</summary>
	public string DestinationFolder;
	///<summary>ConversionFolder</summary>
	public string ConversionFolder;
	///<summary>bPerformSavePackages</summary>
	public bool bPerformSavePackages;
	///<summary>bIgnoreActorLoadingErrors</summary>
	public bool bIgnoreActorLoadingErrors;
	///<summary>DataLayerFactory</summary>
	public UDataLayerFactory DataLayerFactory;
	///<summary>MainWorld</summary>
	public UWorld MainWorld;
}
