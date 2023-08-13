namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Commandlets/WorldPartitionDataLayerToAssetCommandLet.h")]
public partial class UDataLayerConversionInfo : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>DataLayerToConvert</summary>
	public UDeprecatedDataLayerInstance DataLayerToConvert;
	///<summary>DataLayerAsset</summary>
	public UDataLayerAsset DataLayerAsset;
	///<summary>DataLayerInstance</summary>
	public UDataLayerInstanceWithAsset DataLayerInstance;
	///<summary>PreviousConversionsInfo</summary>
	public TArray<TWeakObjectPtr<UDataLayerConversionInfo>> PreviousConversionsInfo;
	///<summary>CurrentConvertingInfo</summary>
	public TWeakObjectPtr<UDataLayerConversionInfo> CurrentConvertingInfo;
}
