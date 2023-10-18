namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FBlueprintPaletteFavorites</summary>
[CppInclude("BlueprintPaletteFavorites.h")]
public partial class UBlueprintPaletteFavorites : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>A list of strings that are used to identify specific palette actions.</summary>
	public TArray<string> CustomFavorites;
	///<summary>A list of favorites that is constructed in PostLoad() (either from a</summary>
	public TArray<FFavoritedBlueprintPaletteItem> CurrentFavorites;
	///<summary>Users could load pre-existing profiles (intended to share favorites, and</summary>
	public string CurrentProfile;
}
