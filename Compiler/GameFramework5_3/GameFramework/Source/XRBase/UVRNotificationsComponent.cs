namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VRNotificationsComponent.h")]
public partial class UVRNotificationsComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>FVRNotificationsDelegate</summary>
	public void FVRNotificationsDelegate() {}
	///<summary>This will be called on Morpheus if the HMD starts up and is not fully initialized (in NOT_STARTED or CALIBRATING states).</summary>
	public FVRNotificationsDelegate HMDTrackingInitializingAndNeedsHMDToBeTrackedDelegate;
	///<summary>This will be called on Morpheus when the HMD is done initializing and therefore</summary>
	public FVRNotificationsDelegate HMDTrackingInitializedDelegate;
	///<summary>This will be called when the application is asked for VR headset recenter.</summary>
	public FVRNotificationsDelegate HMDRecenteredDelegate;
	///<summary>This will be called when connection to HMD is lost.</summary>
	public FVRNotificationsDelegate HMDLostDelegate;
	///<summary>This will be called when connection to HMD is restored.</summary>
	public FVRNotificationsDelegate HMDReconnectedDelegate;
	///<summary>This will be called when the user declines to connect the HMD when prompted to do so by a system dialog. (PS4 Only)</summary>
	public FVRNotificationsDelegate HMDConnectCanceledDelegate;
	///<summary>This will be called when the HMD detects that it has been put on by a player.</summary>
	public FVRNotificationsDelegate HMDPutOnHeadDelegate;
	///<summary>This will be called when the HMD detects that it has been taken off by a player (disconnecting the hmd also causes it to register as taken off).</summary>
	public FVRNotificationsDelegate HMDRemovedFromHeadDelegate;
	///<summary>This will be called when the VR system recenters a controller.</summary>
	public FVRNotificationsDelegate VRControllerRecenteredDelegate;
	///<summary>This will be called whenever the tracking origin is altered.</summary>
	public FVRNotificationsDelegate XRTrackingOriginChangedDelegate;
	///<summary>This will be called whenever the play area is altered.</summary>
	public FVRNotificationsDelegate XRPlayAreaChangedDelegate;
	///<summary>This will be called whenever the interaction profile is altered.</summary>
	public FVRNotificationsDelegate XRInteractionProfileChangedDelegate;
}
