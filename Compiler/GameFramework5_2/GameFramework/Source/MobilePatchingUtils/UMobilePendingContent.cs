#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MobilePatchingLibrary.h")]
public partial class UMobilePendingContent : UMobileInstalledContent {
	public static UClass StaticClass() {return default;}
	///<summary>Get the total download size for this content installation</summary>
	public  float GetDownloadSize() { return default; }
	///<summary>Get the required disk space in megabytes for this content installation</summary>
	public  float GetRequiredDiskSpace() { return default; }
	///<summary>Get the total downloaded size in megabytes. Valid during installation</summary>
	public  float GetTotalDownloadedSize() { return default; }
	///<summary>Get the current download speed in megabytes per second. Valid during installation</summary>
	public  float GetDownloadSpeed() { return default; }
	///<summary>GetDownloadStatusText</summary>
	public  string GetDownloadStatusText() { return default; }
	///<summary>Get the current installation progress. Between 0 and 1 for known progress, or less than 0 for unknown progress</summary>
	public  float GetInstallProgress() { return default; }
	///<summary>Attempt to download and install remote content.</summary>
	public  void StartInstall(FOnContentInstallSucceeded OnSucceeded,FOnContentInstallFailed OnFailed) {}
}
