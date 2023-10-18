namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Keeps track of all the data associated with a screenshot that was taken by the user</summary>
[CppInclude("VirtualCameraSaveGame.h")]
public partial struct FVirtualCameraScreenshot {
	public FVirtualCameraWaypoint Waypoint;
	public FVirtualCameraSettings CameraSettings;
}
