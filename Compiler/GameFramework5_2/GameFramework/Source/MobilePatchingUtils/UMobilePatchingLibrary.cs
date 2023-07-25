#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MobilePatchingLibrary.h")]
public partial class UMobilePatchingLibrary : UBlueprintFunctionLibrary {
// MobilePatchingLibrary
	public UObject GetInstalledContent(string InstallDirectory) { return default; }
	public void RequestContent(string RemoteManifestURL,string CloudURL,string InstallDirectory,FOnRequestContentSucceeded OnSucceeded,FOnRequestContentFailed OnFailed) {}
	public bool HasActiveWiFiConnection() { return default; }
	public string GetActiveDeviceProfileName() { return default; }
	public TArray<string> GetSupportedPlatformNames() { return default; }
}
