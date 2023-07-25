#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
///<summary>Response from a List Project Languages query on OneSky</summary>
public partial struct FOneSkyListProjectLanguagesResponse {
// OneSkyListProjectLanguagesResponse
	public FOneSkyListProjectLanguagesResponseMeta meta;
	public TArray<FOneSkyListProjectLanguagesResponseDataItem> data;
}
