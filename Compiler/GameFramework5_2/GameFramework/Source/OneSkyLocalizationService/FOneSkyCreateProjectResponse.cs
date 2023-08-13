namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Response from a Create Project query on OneSky</summary>
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
public partial struct FOneSkyCreateProjectResponse {
	public FOneSkyCreateProjectResponseMeta meta;
	public FOneSkyCreateProjectResponseData data;
}
