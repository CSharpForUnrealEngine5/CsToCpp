#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WebAPIDeveloperSettings.h")]
///<summary>The base class of any auto generated WebAPI settings object.</summary>
public partial class UWebAPIDeveloperSettings : UDeveloperSettings {
// WebAPIDeveloperSettings
	public string Host;
	public string BaseUrl;
	public string UserAgent;
	public string DateTimeFormat;
	public bool bOverrideScheme;
	public string URISchemeOverride;
	public TArray<string> URISchemes;
	public bool bLogRequests;
	public TArray<UWebAPIAuthenticationSettings> AuthenticationSettings;
}
