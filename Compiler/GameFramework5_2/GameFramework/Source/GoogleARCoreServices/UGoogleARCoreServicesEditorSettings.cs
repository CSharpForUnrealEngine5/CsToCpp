#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper class used to expose GoogleARCoreServices setting in the Editor plugin settings.</summary>
[CppInclude("GoogleARCoreServicesEditorSettings.h")]
public partial class UGoogleARCoreServicesEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The API key for GoogleARCoreServices on Android platform.</summary>
	public string AndroidAPIKey;
	///<summary>The API key for GoogleARCoreServices on iOS platform.</summary>
	public string IOSAPIKey;
}
