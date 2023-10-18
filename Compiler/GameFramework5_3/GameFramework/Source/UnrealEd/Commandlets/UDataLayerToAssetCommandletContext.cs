namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Commandlets/WorldPartitionDataLayerToAssetCommandLet.h")]
public partial class UDataLayerToAssetCommandletContext : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>DataLayerConversionInfo</summary>
	public TArray<UDataLayerConversionInfo> DataLayerConversionInfo;
	///<summary>ConvertingDataLayerInfo</summary>
	public TArray<TWeakObjectPtr<UDataLayerConversionInfo>> ConvertingDataLayerInfo;
}
