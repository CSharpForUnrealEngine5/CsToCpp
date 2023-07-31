#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A class to transfer Camera data in MU session</summary>
[CppInclude("VirtualCameraConcertCameraComponent.h")]
public partial class UDEPRECATED_VirtualCameraConcertCameraComponent : UActorComponent {
	///<summary>The tracked name used by the multi user system to send the data.</summary>
	public string TrackingName;
	///<summary>Is that component sending the camera information or receiving it.</summary>
	public bool bHasAuthority;
	///<summary>When the component has the authority and we are in the editor, we should broadcast the update.</summary>
	public bool bSendUpdateInEditor;
	///<summary>Should update the camera component relative location &amp; rotation.</summary>
	public bool bUpdateCameraComponentTransform;
	///<summary>The camera component that will be tracked.</summary>
	public UCineCameraComponent ComponentToTrack;
}
