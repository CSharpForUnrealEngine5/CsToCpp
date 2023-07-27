#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/GameViewportClient.h")]
///<summary>A game viewport (FViewport) is a high-level abstract interface for the</summary>
public partial class UGameViewportClient : UScriptViewportClient {
// GameViewportClient
	public UConsole ViewportConsole;
	public TArray<FDebugDisplayProperty> DebugProperties;
	public int MaxSplitscreenPlayers;
	public UWorld World;
	public UGameInstance GameInstance;
	public  void SSSwapControllers() {}
	public  void ShowTitleSafeArea() {}
	public  void SetConsoleTarget(int PlayerIndex) {}
}
