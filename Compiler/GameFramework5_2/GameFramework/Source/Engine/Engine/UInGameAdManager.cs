#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/InGameAdManager.h")]
public partial class UInGameAdManager : UPlatformInterfaceBase {
	public static UClass StaticClass() {return default;}
	///<summary>If true, the game will pause when the user clicks on the ad, which could take over the screen</summary>
	public bool bShouldPauseWhileAdOpen;
	///<summary>@todo document</summary>
	public TArray<FOnUserClickedBanner> ClickedBannerDelegates;
	///<summary>@todo document</summary>
	public TArray<FOnUserClosedAdvertisement> ClosedAdDelegates;
}
