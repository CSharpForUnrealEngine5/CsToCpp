namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Each player that is active on the current client/listen server has a LocalPlayer.</summary>
[CppInclude("Engine/LocalPlayer.h")]
public partial class ULocalPlayer : UPlayer {
	public static UClass StaticClass() {return default;}
	///<summary>The primary viewport containing this player&#39;s view.</summary>
	public UGameViewportClient ViewportClient;
	///<summary>How to constrain perspective viewport FOV</summary>
	public EAspectRatioAxisConstraint AspectRatioAxisConstraint;
	///<summary>The class of PlayerController to spawn for players logging in.</summary>
	public UClass PendingLevelPlayerControllerClass;
	///<summary>set when we&#39;ve sent a split join request</summary>
	public bool bSentSplitJoin;
	///<summary>The controller ID which this player accepts input from.</summary>
	public int ControllerId;
}
