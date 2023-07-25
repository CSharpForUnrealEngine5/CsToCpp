#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Security/WebAPIAuthentication.h")]
public partial class UWebAPIOAuthSettings : UWebAPIAuthenticationSettings {
// WebAPIOAuthSettings
	public string ClientId;
	public string ClientSecret;
	public string TokenType;
	public string AccessToken;
	public FDateTime ExpiresOn;
	public string AuthenticationServer;
	public TMap<string,string> AdditionalRequestQueryParameters;
	public TMap<string,string> AdditionalRequestBodyParameters;
}
