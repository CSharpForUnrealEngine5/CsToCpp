namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements an asset that contains a set of overlay data (which includes timing, text, and position) to be displayed for any</summary>
[CppInclude("BasicOverlays.h")]
public partial class UBasicOverlays : UOverlays {
	public static UClass StaticClass() {return default;}
	///<summary>The overlay data held by this asset. Contains info on timing, position, and the subtitle to display</summary>
	public TArray<FOverlayItem> Overlays;
	///<summary>The import data used to make this overlays asset</summary>
	public UAssetImportData AssetImportData;
}
