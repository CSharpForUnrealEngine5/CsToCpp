#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/LocalPlayer.h")]
///<summary>Each player that is active on the current client/listen server has a LocalPlayer.</summary>
public partial class ULocalPlayer : UPlayer {
// LocalPlayer
	public UGameViewportClient ViewportClient;
	public EAspectRatioAxisConstraint AspectRatioAxisConstraint;
	public UClass PendingLevelPlayerControllerClass;
	public bool bSentSplitJoin;
	public int ControllerId;
}
