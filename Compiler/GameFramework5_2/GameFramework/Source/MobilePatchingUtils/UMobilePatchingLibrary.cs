#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MobilePatchingLibrary.h")]
public partial class UMobilePatchingLibrary : UBlueprintFunctionLibrary {
	///<summary>Get the installed content. Will return non-null object if there is an installed content at specified directory</summary>
	public static UMobileInstalledContent GetInstalledContent(string InstallDirectory) { return default; }
	///<summary>Attempt to download manifest file using specified manifest URL.</summary>
	public static void RequestContent(string RemoteManifestURL,string CloudURL,string InstallDirectory,FOnRequestContentSucceeded OnSucceeded,FOnRequestContentFailed OnFailed) {}
	///<summary>Whether WiFi connection is currently available</summary>
	public static bool HasActiveWiFiConnection() { return default; }
	///<summary>Get the name of currently selected device profile name</summary>
	public static string GetActiveDeviceProfileName() { return default; }
	///<summary>Get the list of supported platform names on this device. Example: Android_ETC2, Android_ASTC</summary>
	public static TArray<string> GetSupportedPlatformNames() { return default; }
}
