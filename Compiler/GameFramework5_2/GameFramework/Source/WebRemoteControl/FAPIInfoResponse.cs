namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
public partial struct FAPIInfoResponse {
	public TArray<FRemoteControlRouteDescription> HttpRoutes;
	public FRCShortPresetDescription ActivePreset;
}
