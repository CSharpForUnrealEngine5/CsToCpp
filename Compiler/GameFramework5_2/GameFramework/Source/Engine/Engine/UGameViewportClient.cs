namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A game viewport (FViewport) is a high-level abstract interface for the</summary>
[CppInclude("Engine/GameViewportClient.h")]
public partial class UGameViewportClient : UScriptViewportClient {
	public static UClass StaticClass() {return default;}
	///<summary>The viewport&#39;s console.   Might be null on consoles</summary>
	public UConsole ViewportConsole;
	///<summary>Debug properties that have been added via one of the &quot;displayall&quot; commands</summary>
	public TArray<FDebugDisplayProperty> DebugProperties;
	///<summary>MaxSplitscreenPlayers</summary>
	public int MaxSplitscreenPlayers;
	///<summary>The relative world context for this viewport</summary>
	public UWorld World;
	///<summary>GameInstance</summary>
	public UGameInstance GameInstance;
	///<summary>Rotates controller ids among gameplayers, useful for testing splitscreen with only one controller.</summary>
	public virtual void SSSwapControllers() {}
	///<summary>Exec for toggling the display of the title safe area</summary>
	public virtual void ShowTitleSafeArea() {}
	///<summary>Sets the player which console commands will be executed in the context of.</summary>
	public virtual void SetConsoleTarget(int PlayerIndex) {}
}
