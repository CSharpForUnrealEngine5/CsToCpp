#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VRNotificationsComponent.h")]
public partial class UVRNotificationsComponent : UActorComponent {
// VRNotificationsComponent
	public void FVRNotificationsDelegate() {}
	public FVRNotificationsDelegate HMDTrackingInitializingAndNeedsHMDToBeTrackedDelegate;
	public FVRNotificationsDelegate HMDTrackingInitializedDelegate;
	public FVRNotificationsDelegate HMDRecenteredDelegate;
	public FVRNotificationsDelegate HMDLostDelegate;
	public FVRNotificationsDelegate HMDReconnectedDelegate;
	public FVRNotificationsDelegate HMDConnectCanceledDelegate;
	public FVRNotificationsDelegate HMDPutOnHeadDelegate;
	public FVRNotificationsDelegate HMDRemovedFromHeadDelegate;
	public FVRNotificationsDelegate VRControllerRecenteredDelegate;
	public FVRNotificationsDelegate XRTrackingOriginChangedDelegate;
	public FVRNotificationsDelegate XRPlayAreaChangedDelegate;
	public FVRNotificationsDelegate XRInteractionProfileChangedDelegate;
}
