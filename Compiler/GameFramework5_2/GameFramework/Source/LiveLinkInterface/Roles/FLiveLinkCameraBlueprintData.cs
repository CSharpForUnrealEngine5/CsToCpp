namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Facility structure to handle camera data in blueprint</summary>
[CppInclude("Roles/LiveLinkCameraTypes.h")]
public partial struct FLiveLinkCameraBlueprintData {
	public FLiveLinkCameraStaticData StaticData;
	public FLiveLinkCameraFrameData FrameData;
}
