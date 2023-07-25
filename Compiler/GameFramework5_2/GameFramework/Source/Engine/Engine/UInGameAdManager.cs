#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/InGameAdManager.h")]
public partial class UInGameAdManager : UPlatformInterfaceBase {
// InGameAdManager
	public bool bShouldPauseWhileAdOpen;
	public TArray<FOnUserClickedBanner> ClickedBannerDelegates;
	public TArray<FOnUserClosedAdvertisement> ClosedAdDelegates;
}
