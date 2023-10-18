namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This widget can be given an asset and it will render its thumbnail. Editor-only.</summary>
[CppInclude("Components/AssetThumbnailWidget.h")]
public partial class UAssetThumbnailWidget : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>SetThumbnailSettings</summary>
	public void SetThumbnailSettings(FAssetThumbnailWidgetSettings InThumbnailSettings) {}
	///<summary>SetAsset</summary>
	public void SetAsset(FAssetData AssetData) {}
	///<summary>SetAssetByObject</summary>
	public void SetAssetByObject(UObject Object) {}
	///<summary>Sets the resolution for the rendered thumbnail.</summary>
	public void SetResolution(FIntPoint InResolution) {}
	///<summary>Gets the resolution of the rendered thumbnail.</summary>
	public FIntPoint GetResolution() { return default; }
	///<summary>The asset of which to show the thumbnail.</summary>
	public FAssetData AssetToShow;
	///<summary>Desired size of the thumbnail</summary>
	public FIntPoint Resolution;
	///<summary>Behaviour and style of the widget</summary>
	public FAssetThumbnailWidgetSettings ThumbnailSettings;
}
