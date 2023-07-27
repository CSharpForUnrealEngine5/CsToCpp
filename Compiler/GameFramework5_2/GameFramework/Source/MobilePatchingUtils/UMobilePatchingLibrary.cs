#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MobilePatchingLibrary.h")]
public partial class UMobilePatchingLibrary : UBlueprintFunctionLibrary {
// MobilePatchingLibrary
	public static UMobileInstalledContent GetInstalledContent(string InstallDirectory) { return default; }
	public static void RequestContent(string RemoteManifestURL,string CloudURL,string InstallDirectory,FOnRequestContentSucceeded OnSucceeded,FOnRequestContentFailed OnFailed) {}
	public static bool HasActiveWiFiConnection() { return default; }
	public static string GetActiveDeviceProfileName() { return default; }
	public static TArray<string> GetSupportedPlatformNames() { return default; }
}
