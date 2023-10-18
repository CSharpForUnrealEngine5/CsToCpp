namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Response from a List Projects in Group query on OneSky</summary>
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
public partial struct FOneSkyListProjectsInGroupResponse {
	public FOneSkyListProjectsInGroupResponseMeta meta;
	public TArray<FOneSkyListProjectsInGroupResponseDataItem> data;
}
