#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Response from a List Uploaded Files query on OneSky</summary>
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
public partial struct FOneSkyListPhraseCollectionsResponse {
	public FOneSkyListPhraseCollectionsResponseMeta meta;
	public TArray<FOneSkyListPhraseCollectionsResponseDataItem> data;
}
