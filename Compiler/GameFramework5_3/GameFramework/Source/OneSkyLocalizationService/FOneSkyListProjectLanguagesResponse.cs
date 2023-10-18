namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Response from a List Project Languages query on OneSky</summary>
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
public partial struct FOneSkyListProjectLanguagesResponse {
	public FOneSkyListProjectLanguagesResponseMeta meta;
	public TArray<FOneSkyListProjectLanguagesResponseDataItem> data;
}
