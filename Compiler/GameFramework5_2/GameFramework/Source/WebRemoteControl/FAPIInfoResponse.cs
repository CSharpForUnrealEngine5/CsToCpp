#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
public partial struct FAPIInfoResponse {
// APIInfoResponse
	public TArray<FRemoteControlRouteDescription> HttpRoutes;
	public FRCShortPresetDescription ActivePreset;
}
