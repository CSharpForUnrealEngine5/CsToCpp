namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Response from a List Uploaded Files query on OneSky</summary>
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
public partial struct FOneSkyListUploadedFilesResponse {
	public FOneSkyListUploadedFilesResponseMeta meta;
	public TArray<FOneSkyListUploadedFilesResponseDataItem> data;
}
