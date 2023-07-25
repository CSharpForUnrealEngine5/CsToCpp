#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dom/WebAPIOperation.h")]
public partial class UWebAPIOperation : UObject {
// WebAPIOperation
	public FWebAPITypeNameVariant Name;
	public bool bGenerate;
	public UWebAPIService Service;
	public string Description;
	public bool bIsDeprecated;
	public string Verb;
	public string Path;
	public TArray<string> RequestContentTypes;
	public TArray<string> ResponseContentTypes;
	public UWebAPIOperationRequest Request;
	public TArray<UWebAPIOperationResponse> Responses;
	public TArray<UWebAPIOperationError> Errors;
	public string GeneratedCodeText;
}
