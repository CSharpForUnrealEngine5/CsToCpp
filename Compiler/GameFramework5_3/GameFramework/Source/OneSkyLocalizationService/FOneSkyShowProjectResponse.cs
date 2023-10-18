namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Response from a Show Project query on OneSky</summary>
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
public partial struct FOneSkyShowProjectResponse {
	public FOneSkyShowProjectResponseMeta meta;
	public FOneSkyShowProjectResponseData data;
}
