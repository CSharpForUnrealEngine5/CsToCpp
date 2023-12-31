namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The base class of any auto generated WebAPI settings object.</summary>
[CppInclude("WebAPIDeveloperSettings.h")]
public partial class UWebAPIDeveloperSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>The default host address to access this API.</summary>
	public string Host;
	///<summary>The Url path relative to the host address, ie. &quot;/V1&quot;.</summary>
	public string BaseUrl;
	///<summary>The UserAgent to encode in Http request headers.</summary>
	public string UserAgent;
	///<summary>The date-time format this API uses to encode/decode from string.</summary>
	public string DateTimeFormat;
	///<summary>Whether to override the URI scheme.</summary>
	public bool bOverrideScheme;
	///<summary>User specified Uniform Resource Identifier scheme.</summary>
	public string URISchemeOverride;
	///<summary>Uniform Resource Identifier schemes (ie. https, http).</summary>
	public TArray<string> URISchemes;
	///<summary>Whether to print requests to the output log, useful for debugging.</summary>
	public bool bLogRequests;
	///<summary>Authentication settings per security scheme.</summary>
	public TArray<UWebAPIAuthenticationSettings> AuthenticationSettings;
}
