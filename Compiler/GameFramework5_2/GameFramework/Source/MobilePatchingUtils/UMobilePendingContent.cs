#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MobilePatchingLibrary.h")]
public partial class UMobilePendingContent : UMobileInstalledContent {
// MobilePendingContent
	public float GetDownloadSize() { return default; }
	public float GetRequiredDiskSpace() { return default; }
	public float GetTotalDownloadedSize() { return default; }
	public float GetDownloadSpeed() { return default; }
	public string GetDownloadStatusText() { return default; }
	public float GetInstallProgress() { return default; }
	public void StartInstall(FOnContentInstallSucceeded OnSucceeded,FOnContentInstallFailed OnFailed) {}
}
