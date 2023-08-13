namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Response from an Upload File post to OneSky</summary>
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
public partial struct FOneSkyUploadFileResponse {
	public FOneSkyUploadFileResponseMeta meta;
	public FOneSkyUploadFileResponseData data;
}
