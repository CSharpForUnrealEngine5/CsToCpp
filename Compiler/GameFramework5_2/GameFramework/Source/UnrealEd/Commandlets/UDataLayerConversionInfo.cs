#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Commandlets/WorldPartitionDataLayerToAssetCommandLet.h")]
public partial class UDataLayerConversionInfo : UObject {
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
