#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dom/WebAPISchema.h")]
///<summary>Describes the intermediate structure from which to generate code.</summary>
public partial class UWebAPISchema : UObject {
// WebAPISchema
	public string APIName;
	public string Version;
	public string Host;
	public string BaseUrl;
	public string UserAgent;
	public string DateTimeFormat;
	public TArray<string> URISchemes;
	public UWebAPITypeRegistry TypeRegistry;
	public TArray<UWebAPIModelBase> Models;
	public TMap<string,UWebAPIService> Services;
}
