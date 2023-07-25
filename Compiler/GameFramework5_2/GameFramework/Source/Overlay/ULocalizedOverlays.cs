#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LocalizedOverlays.h")]
///<summary>Implements an asset that contains a set of Basic Overlays that will be displayed in accordance with</summary>
public partial class ULocalizedOverlays : UOverlays {
// LocalizedOverlays
	public UBasicOverlays DefaultOverlays;
	public TMap<string,UBasicOverlays> LocaleToOverlaysMap;
	public UAssetImportData AssetImportData;
}
