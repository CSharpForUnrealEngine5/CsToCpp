#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetInternationalizationLibrary.h")]
public partial class UKismetInternationalizationLibrary : UBlueprintFunctionLibrary {
// KismetInternationalizationLibrary
	public static bool SetCurrentCulture(string Culture,bool SaveToConfig/*=false*/) { return default; }
	public static string GetCurrentCulture() { return default; }
	public static bool SetCurrentLanguage(string Culture,bool SaveToConfig/*=false*/) { return default; }
	public static string GetCurrentLanguage() { return default; }
	public static bool SetCurrentLocale(string Culture,bool SaveToConfig/*=false*/) { return default; }
	public static string GetCurrentLocale() { return default; }
	public static bool SetCurrentLanguageAndLocale(string Culture,bool SaveToConfig/*=false*/) { return default; }
	public static bool SetCurrentAssetGroupCulture(string AssetGroup,string Culture,bool SaveToConfig/*=false*/) { return default; }
	public static string GetCurrentAssetGroupCulture(string AssetGroup) { return default; }
	public static void ClearCurrentAssetGroupCulture(string AssetGroup,bool SaveToConfig/*=false*/) {}
	public static string GetNativeCulture(ELocalizedTextSourceCategory TextCategory) { return default; }
	public static TArray<string> GetLocalizedCultures(bool IncludeGame/*=true*/,bool IncludeEngine/*=false*/,bool IncludeEditor/*=false*/,bool IncludeAdditional/*=false*/) { return default; }
	public static string GetSuitableCulture(TArray<string> AvailableCultures,string CultureToMatch,string FallbackCulture/*=TEXT("en")*/) { return default; }
	public static string GetCultureDisplayName(string Culture,bool Localized/*=true*/) { return default; }
}
