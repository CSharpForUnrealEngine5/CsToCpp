#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetInternationalizationLibrary.h")]
public partial class UKismetInternationalizationLibrary : UBlueprintFunctionLibrary {
// KismetInternationalizationLibrary
	public bool SetCurrentCulture(string Culture,bool SaveToConfig/*=false*/) { return default; }
	public string GetCurrentCulture() { return default; }
	public bool SetCurrentLanguage(string Culture,bool SaveToConfig/*=false*/) { return default; }
	public string GetCurrentLanguage() { return default; }
	public bool SetCurrentLocale(string Culture,bool SaveToConfig/*=false*/) { return default; }
	public string GetCurrentLocale() { return default; }
	public bool SetCurrentLanguageAndLocale(string Culture,bool SaveToConfig/*=false*/) { return default; }
	public bool SetCurrentAssetGroupCulture(string AssetGroup,string Culture,bool SaveToConfig/*=false*/) { return default; }
	public string GetCurrentAssetGroupCulture(string AssetGroup) { return default; }
	public void ClearCurrentAssetGroupCulture(string AssetGroup,bool SaveToConfig/*=false*/) {}
	public string GetNativeCulture(ELocalizedTextSourceCategory TextCategory) { return default; }
	public TArray<string> GetLocalizedCultures(bool IncludeGame/*=true*/,bool IncludeEngine/*=false*/,bool IncludeEditor/*=false*/,bool IncludeAdditional/*=false*/) { return default; }
	public string GetSuitableCulture(TArray<string> AvailableCultures,string CultureToMatch,string FallbackCulture/*=TEXT("en")*/) { return default; }
	public string GetCultureDisplayName(string Culture,bool Localized/*=true*/) { return default; }
}
