#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
///<summary>Response from a List Project Group Languages query on OneSky</summary>
public partial struct FOneSkyListProjectGroupLanguagesResponse {
// OneSkyListProjectGroupLanguagesResponse
	public FOneSkyListProjectGroupLanguagesResponseMeta meta;
	public TArray<FOneSkyListProjectGroupLanguagesResponseDataItem> data;
}
