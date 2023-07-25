#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Commandlets/WorldPartitionDataLayerToAssetCommandLet.h")]
public partial class UDataLayerConversionInfo : UObject {
// DataLayerConversionInfo
	public UDeprecatedDataLayerInstance DataLayerToConvert;
	public UDataLayerAsset DataLayerAsset;
	public UDataLayerInstanceWithAsset DataLayerInstance;
	public TArray<TWeakObjectPtr<UDataLayerConversionInfo>> PreviousConversionsInfo;
	public TWeakObjectPtr<UDataLayerConversionInfo> CurrentConvertingInfo;
}
