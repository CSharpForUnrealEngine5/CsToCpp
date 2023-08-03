#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dom/WebAPIOperation.h")]
public partial class UWebAPIOperation : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Name of the Operation.</summary>
	public FWebAPITypeNameVariant Name;
	///<summary>Can be disabled to skip generation of this Operation.</summary>
	public bool bGenerate;
	///<summary>Parent service for this operation.</summary>
	public UWebAPIService Service;
	///<summary>Describes this operation.</summary>
	public string Description;
	///<summary>Flags an operation previously available as deprecated.</summary>
	public bool bIsDeprecated;
	///<summary>The Http verb, ie. Get, Post, etc.</summary>
	public string Verb;
	///<summary>The operation path, relative to the base url. This can contain named template args.</summary>
	public string Path;
	///<summary>List of possible content types for requests, ie. application/json</summary>
	public TArray<string> RequestContentTypes;
	///<summary>List of possible content types for responses, ie. application/json</summary>
	public TArray<string> ResponseContentTypes;
	///<summary>Request model.</summary>
	public UWebAPIOperationRequest Request;
	///<summary>Array of responses.</summary>
	public TArray<UWebAPIOperationResponse> Responses;
	///<summary>Array of errors that can be returned.</summary>
	public TArray<UWebAPIOperationError> Errors;
	///<summary>The last generated code as text for debugging.</summary>
	public string GeneratedCodeText;
}
