#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraConcertCameraComponent.h")]
///<summary>A class to transfer Camera data in MU session</summary>
public partial class UDEPRECATED_VirtualCameraConcertCameraComponent : UActorComponent {
// VirtualCameraConcertCameraComponent
	public string TrackingName;
	public bool bHasAuthority;
	public bool bSendUpdateInEditor;
	public bool bUpdateCameraComponentTransform;
	public UCineCameraComponent ComponentToTrack;
}
