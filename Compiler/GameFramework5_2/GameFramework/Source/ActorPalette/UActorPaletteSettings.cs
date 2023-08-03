#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings/preferences for Actor Palettes</summary>
[CppInclude("ActorPaletteSettings.h")]
public partial class UActorPaletteSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Remembered settings for any recent/current/favorite actor palette maps</summary>
	public TArray<FActorPaletteMapEntry> SettingsPerLevel;
	///<summary>List of levels that were recently open in any Actor Palette tab</summary>
	public TArray<string> RecentlyUsedList;
	///<summary>List of levels that were last open in each Actor Palette tab (indexed by tab index)</summary>
	public TArray<string> MostRecentLevelByTab;
	///<summary>List of levels that were marked as favorite actor palettes</summary>
	public TArray<string> FavoritesList;
	///<summary>How many recent levels will be remembered?</summary>
	public int NumRecentLevelsToKeep;
}
