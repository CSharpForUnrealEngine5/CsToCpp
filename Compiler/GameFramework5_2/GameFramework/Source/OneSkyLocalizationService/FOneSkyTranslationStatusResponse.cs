namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Response from a Translation Status query on OneSky</summary>
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
public partial struct FOneSkyTranslationStatusResponse {
	public FOneSkyTranslationStatusResponseMeta meta;
	public FOneSkyTranslationStatusResponseData data;
}
