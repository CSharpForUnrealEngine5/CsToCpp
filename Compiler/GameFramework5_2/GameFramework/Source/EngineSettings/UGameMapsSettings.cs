#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameMapsSettings.h")]
public partial class UGameMapsSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>If set, this map will be loaded when the Editor starts up.</summary>
	public FSoftObjectPath EditorStartupMap;
	///<summary>Map templates that should show up in the new level dialog. This will completely override the default maps chosen by the default editor</summary>
	public TArray<FTemplateMapInfoOverride> EditorTemplateMapOverrides;
	///<summary>The default options that will be appended to a map being loaded.</summary>
	public string LocalMapOptions;
	///<summary>The map loaded when transition from one map to another.</summary>
	public FSoftObjectPath TransitionMap;
	///<summary>Whether the screen should be split or not when multiple local players are present</summary>
	public bool bUseSplitscreen;
	///<summary>The viewport layout to use if the screen should be split and there are two local players</summary>
	public ETwoPlayerSplitScreenType TwoPlayerSplitscreenLayout;
	///<summary>The viewport layout to use if the screen should be split and there are three local players</summary>
	public EThreePlayerSplitScreenType ThreePlayerSplitscreenLayout;
	///<summary>The viewport layout to use if the screen should be split and there are three local players</summary>
	public EFourPlayerSplitScreenType FourPlayerSplitscreenLayout;
	///<summary>If enabled, this will make so that gamepads start being assigned to the second controller ID in local multiplayer games.</summary>
	public bool bOffsetPlayerGamepadIds;
	///<summary>The class to use when instantiating the transient GameInstance class</summary>
	public FSoftClassPath GameInstanceClass;
	///<summary>The map that will be loaded by default when no other map is loaded.</summary>
	public FSoftObjectPath GameDefaultMap;
	///<summary>The map that will be loaded by default when no other map is loaded (DEDICATED SERVER).</summary>
	public FSoftObjectPath ServerDefaultMap;
	///<summary>GameMode to use if not specified in any other way. (e.g. per-map DefaultGameMode or on the URL).</summary>
	public FSoftClassPath GlobalDefaultGameMode;
	///<summary>GameMode to use if not specified in any other way. (e.g. per-map DefaultGameMode or on the URL) (DEDICATED SERVERS)</summary>
	public FSoftClassPath GlobalDefaultServerGameMode;
	///<summary>Overrides the GameMode to use when loading a map that starts with a specific prefix</summary>
	public TArray<FGameModeName> GameModeMapPrefixes;
	///<summary>List of GameModes to load when game= is specified in the URL (e.g. &quot;DM&quot; could be an alias for &quot;MyProject.MyGameModeMP_DM&quot;)</summary>
	public TArray<FGameModeName> GameModeClassAliases;
	///<summary>Returns the game local maps settings</summary>
	public static UGameMapsSettings GetGameMapsSettings() { return default; }
	///<summary>Modify &quot;Skip Assigning Gamepad to Player 1&quot; GameMapsSettings option</summary>
	public  void SetSkipAssigningGamepadToPlayer1(bool bSkipFirstPlayer/*=true*/) {}
	///<summary>GetSkipAssigningGamepadToPlayer1</summary>
	public  bool GetSkipAssigningGamepadToPlayer1() { return default; }
}
