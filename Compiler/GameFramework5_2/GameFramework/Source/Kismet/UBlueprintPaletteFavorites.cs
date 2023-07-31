#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FBlueprintPaletteFavorites</summary>
[CppInclude("BlueprintPaletteFavorites.h")]
public partial class UBlueprintPaletteFavorites : UObject {
	///<summary>A list of strings that are used to identify specific palette actions.</summary>
	public TArray<string> CustomFavorites;
	///<summary>A list of favorites that is constructed in PostLoad() (either from a</summary>
	public TArray<FFavoritedBlueprintPaletteItem> CurrentFavorites;
	///<summary>Users could load pre-existing profiles (intended to share favorites, and</summary>
	public string CurrentProfile;
}
