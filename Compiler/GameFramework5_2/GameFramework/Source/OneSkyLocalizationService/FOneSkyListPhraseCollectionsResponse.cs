#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
///<summary>Response from a List Uploaded Files query on OneSky</summary>
public partial struct FOneSkyListPhraseCollectionsResponse {
// OneSkyListPhraseCollectionsResponse
	public FOneSkyListPhraseCollectionsResponseMeta meta;
	public TArray<FOneSkyListPhraseCollectionsResponseDataItem> data;
}
