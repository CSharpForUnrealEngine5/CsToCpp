#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameMapsSettings.h")]
public partial class UGameMapsSettings : UObject {
// GameMapsSettings
	public FSoftObjectPath EditorStartupMap;
	public TArray<FTemplateMapInfoOverride> EditorTemplateMapOverrides;
	public string LocalMapOptions;
	public FSoftObjectPath TransitionMap;
	public bool bUseSplitscreen;
	public ETwoPlayerSplitScreenType TwoPlayerSplitscreenLayout;
	public EThreePlayerSplitScreenType ThreePlayerSplitscreenLayout;
	public EFourPlayerSplitScreenType FourPlayerSplitscreenLayout;
	public bool bOffsetPlayerGamepadIds;
	public FSoftClassPath GameInstanceClass;
	public FSoftObjectPath GameDefaultMap;
	public FSoftObjectPath ServerDefaultMap;
	public FSoftClassPath GlobalDefaultGameMode;
	public FSoftClassPath GlobalDefaultServerGameMode;
	public TArray<FGameModeName> GameModeMapPrefixes;
	public TArray<FGameModeName> GameModeClassAliases;
	public static UGameMapsSettings GetGameMapsSettings() { return default; }
	public  void SetSkipAssigningGamepadToPlayer1(bool bSkipFirstPlayer/*=true*/) {}
	public  bool GetSkipAssigningGamepadToPlayer1() { return default; }
}
