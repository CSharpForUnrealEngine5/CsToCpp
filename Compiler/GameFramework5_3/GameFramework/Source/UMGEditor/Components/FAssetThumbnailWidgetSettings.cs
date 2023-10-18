namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Copied mostly from FAssetThumbnailConfig</summary>
[CppInclude("Components/AssetThumbnailWidget.h")]
public partial struct FAssetThumbnailWidgetSettings {
	public bool bForceGenericThumbnail;
	public bool bAllowHintText;
	public bool bAllowRealTimeOnHovered;
	public bool bAllowAssetSpecificThumbnailOverlay;
	public EThumbnailLabelType_BlueprintType ThumbnailLabel;
	public FGetHighlightTextDelegate HighlightedTextDelegate;
	public FLinearColor HintColorAndOpacity;
	public bool bOverrideAssetTypeColor;
	public FLinearColor AssetTypeColorOverride;
	public FMargin Padding;
	public int GenericThumbnailSize;
	public EThumbnailColorStripOrientation_BlueprintType ColorStripOrientation;
}
