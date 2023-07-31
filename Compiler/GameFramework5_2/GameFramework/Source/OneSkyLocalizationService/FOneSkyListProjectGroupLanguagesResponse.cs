#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Response from a List Project Group Languages query on OneSky</summary>
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
public partial struct FOneSkyListProjectGroupLanguagesResponse {
	public FOneSkyListProjectGroupLanguagesResponseMeta meta;
	public TArray<FOneSkyListProjectGroupLanguagesResponseDataItem> data;
}
