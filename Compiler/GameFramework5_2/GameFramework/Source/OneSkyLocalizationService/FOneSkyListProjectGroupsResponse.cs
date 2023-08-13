namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Response from a List Project Groups query on OneSky</summary>
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
public partial struct FOneSkyListProjectGroupsResponse {
	public FOneSkyListProjectGroupsResponseMeta meta;
	public TArray<FOneSkyListProjectGroupsResponseDataItem> data;
}
