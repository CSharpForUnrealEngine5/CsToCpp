namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes the intermediate structure from which to generate code.</summary>
[CppInclude("Dom/WebAPISchema.h")]
public partial class UWebAPISchema : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Name of the API.</summary>
	public string APIName;
	///<summary>The API version can be any arbitrary string that is useful if there are several versions.</summary>
	public string Version;
	///<summary>The default host address to access this API.</summary>
	public string Host;
	///<summary>The Url path relative to the host address, ie. &quot;/V1&quot;.</summary>
	public string BaseUrl;
	///<summary>The UserAgent to encode in Http request headers.</summary>
	public string UserAgent;
	///<summary>The date-time format this API uses to encode/decode from string.</summary>
	public string DateTimeFormat;
	///<summary>Uniform Resource Identifier schemes (ie. https, http).</summary>
	public TArray<string> URISchemes;
	///<summary>Contains all referenced types for this API.</summary>
	public UWebAPITypeRegistry TypeRegistry;
	///<summary>Models can be a combination of classes, structs and enums used by this API.</summary>
	public TArray<UWebAPIModelBase> Models;
	///<summary>Each service contains one or more operations.</summary>
	public TMap<string,UWebAPIService> Services;
}
