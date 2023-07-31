#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Response from a Translation Status query on OneSky</summary>
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
public partial struct FOneSkyTranslationStatusResponse {
	public FOneSkyTranslationStatusResponseMeta meta;
	public FOneSkyTranslationStatusResponseData data;
}
