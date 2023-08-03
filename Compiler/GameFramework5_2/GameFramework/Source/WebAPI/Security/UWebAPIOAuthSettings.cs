#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Security/WebAPIAuthentication.h")]
public partial class UWebAPIOAuthSettings : UWebAPIAuthenticationSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Public client identifier.</summary>
	public string ClientId;
	///<summary>Private client secret.</summary>
	public string ClientSecret;
	///<summary>Token type, ie. Bearer</summary>
	public string TokenType;
	///<summary>Private token returned by the server.</summary>
	public string AccessToken;
	///<summary>Private token expiration returned by the server.</summary>
	public FDateTime ExpiresOn;
	///<summary>Authentication endpoint.</summary>
	public string AuthenticationServer;
	///<summary>Additional query parameters to add to auth request. Each key should be present in the Url.</summary>
	public TMap<string,string> AdditionalRequestQueryParameters;
	///<summary>Additional content key/value pairs to add to auth request.</summary>
	public TMap<string,string> AdditionalRequestBodyParameters;
}
