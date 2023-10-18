namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Version of UAssetThumbnailWidget that compiles in packaged games.</summary>
[CppInclude("Widgets/VPAssetThumbnailWrapperWidget.h")]
public partial class UVPAssetThumbnailWrapperWidget : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>Sets the resolution of the editor thumbnail</summary>
	public void SetEditorThumbnailResolution(FIntPoint NewResolution) {}
	///<summary>GetEditorThumbnailResolution</summary>
	public FIntPoint GetEditorThumbnailResolution() { return default; }
	///<summary>Gets the widget used for displaying in editor. Returns nullptr in non-editor builds.</summary>
	public UObject GetEditorAssetWidget() { return default; }
	///<summary>Sets the asset to display. Has no effect in non-editor builds.</summary>
	public void SetAsset(FAssetData AssetData) {}
	///<summary>Sets the asset to display. Has no effect in non-editor builds.</summary>
	public void SetAssetByObject(UObject Object) {}
	///<summary>Sets the fallback image to display.</summary>
	public void SetFallbackBrush(FSlateBrush NewFallbackBrush) {}
	///<summary>GetFallbackBrush</summary>
	public FSlateBrush GetFallbackBrush() { return default; }
	///<summary>Sets the display mode. Only has an effect in editor builds because packaged games always display in FallbackImage mode.</summary>
	public void SetDisplayMode(EAssetThumbnailDisplayMode Mode/*=EAssetThumbnailDisplayMode.FallbackImage*/) {}
	///<summary>Fallback brush to draw</summary>
	public FSlateBrush FallbackBrush;
	///<summary>The content for the editor version. Is an instance of UAssetThumbnailWidget but for non-editor builds UHT does not find the type so UObject here.</summary>
	public UObject AssetWidget;
	///<summary>How the widget is supposed to be displayed.</summary>
	public EAssetThumbnailDisplayMode DisplayMode;
}
