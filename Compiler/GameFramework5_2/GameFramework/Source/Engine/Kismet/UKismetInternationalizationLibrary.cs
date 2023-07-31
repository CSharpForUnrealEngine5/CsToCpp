#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetInternationalizationLibrary.h")]
public partial class UKismetInternationalizationLibrary : UBlueprintFunctionLibrary {
	///<summary>Set the current culture.</summary>
	public static bool SetCurrentCulture(string Culture,bool SaveToConfig/*=false*/) { return default; }
	///<summary>Get the current culture as an IETF language tag:</summary>
	public static string GetCurrentCulture() { return default; }
	///<summary>Set *only* the current language (for localization).</summary>
	public static bool SetCurrentLanguage(string Culture,bool SaveToConfig/*=false*/) { return default; }
	///<summary>Get the current language (for localization) as an IETF language tag:</summary>
	public static string GetCurrentLanguage() { return default; }
	///<summary>Set *only* the current locale (for internationalization).</summary>
	public static bool SetCurrentLocale(string Culture,bool SaveToConfig/*=false*/) { return default; }
	///<summary>Get the current locale (for internationalization) as an IETF language tag:</summary>
	public static string GetCurrentLocale() { return default; }
	///<summary>Set the current language (for localization) and locale (for internationalization).</summary>
	public static bool SetCurrentLanguageAndLocale(string Culture,bool SaveToConfig/*=false*/) { return default; }
	///<summary>Set the given asset group category culture from an IETF language tag (eg, &quot;zh-Hans-CN&quot;).</summary>
	public static bool SetCurrentAssetGroupCulture(string AssetGroup,string Culture,bool SaveToConfig/*=false*/) { return default; }
	///<summary>Get the given asset group category culture.</summary>
	public static string GetCurrentAssetGroupCulture(string AssetGroup) { return default; }
	///<summary>Clear the given asset group category culture.</summary>
	public static void ClearCurrentAssetGroupCulture(string AssetGroup,bool SaveToConfig/*=false*/) {}
	///<summary>Get the native culture for the given localization category.</summary>
	public static string GetNativeCulture(ELocalizedTextSourceCategory TextCategory) { return default; }
	///<summary>Get the list of cultures that have localization data available for them.</summary>
	public static TArray<string> GetLocalizedCultures(bool IncludeGame/*=true*/,bool IncludeEngine/*=false*/,bool IncludeEditor/*=false*/,bool IncludeAdditional/*=false*/) { return default; }
	///<summary>Given a list of available cultures, try and find the most suitable culture from the list based on culture prioritization.</summary>
	public static string GetSuitableCulture(TArray<string> AvailableCultures,string CultureToMatch,string FallbackCulture/*=TEXT("en")*/) { return default; }
	///<summary>Get the display name of the given culture.</summary>
	public static string GetCultureDisplayName(string Culture,bool Localized/*=true*/) { return default; }
}
