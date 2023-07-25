#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
///<summary>Response from a List Project Groups query on OneSky</summary>
public partial struct FOneSkyListProjectGroupsResponse {
// OneSkyListProjectGroupsResponse
	public FOneSkyListProjectGroupsResponseMeta meta;
	public TArray<FOneSkyListProjectGroupsResponseDataItem> data;
}
