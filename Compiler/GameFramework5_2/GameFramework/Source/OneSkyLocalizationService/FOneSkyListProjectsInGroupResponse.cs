#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
///<summary>Response from a List Projects in Group query on OneSky</summary>
public partial struct FOneSkyListProjectsInGroupResponse {
// OneSkyListProjectsInGroupResponse
	public FOneSkyListProjectsInGroupResponseMeta meta;
	public TArray<FOneSkyListProjectsInGroupResponseDataItem> data;
}
