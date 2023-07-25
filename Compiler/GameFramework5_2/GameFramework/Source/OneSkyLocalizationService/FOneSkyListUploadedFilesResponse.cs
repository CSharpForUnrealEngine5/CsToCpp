#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
///<summary>Response from a List Uploaded Files query on OneSky</summary>
public partial struct FOneSkyListUploadedFilesResponse {
// OneSkyListUploadedFilesResponse
	public FOneSkyListUploadedFilesResponseMeta meta;
	public TArray<FOneSkyListUploadedFilesResponseDataItem> data;
}
