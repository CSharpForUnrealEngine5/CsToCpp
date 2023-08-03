#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements an asset that contains a set of Basic Overlays that will be displayed in accordance with</summary>
[CppInclude("LocalizedOverlays.h")]
public partial class ULocalizedOverlays : UOverlays {
	public static UClass StaticClass() {return default;}
	///<summary>The overlays to use if no overlays are found for the current culture</summary>
	public UBasicOverlays DefaultOverlays;
	///<summary>Maps a set of cultures to specific BasicOverlays assets.</summary>
	public TMap<string,UBasicOverlays> LocaleToOverlaysMap;
	///<summary>The import data used to make this overlays asset</summary>
	public UAssetImportData AssetImportData;
}
