namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Response from a Create Project Group query on OneSky</summary>
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
public partial struct FOneSkyCreateProjectGroupResponse {
	public FOneSkyCreateProjectGroupResponseMeta meta;
	public FOneSkyCreateProjectGroupResponseData data;
}
