namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HeadMountedDisplayFunctionLibrary.h")]
public partial class UHeadMountedDisplayFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns whether or not we are currently using the head mounted display.</summary>
	public static bool IsHeadMountedDisplayEnabled() { return default; }
	///<summary>Returns whether or not the HMD hardware is connected and ready to use.  It may or may not actually be in use.</summary>
	public static bool IsHeadMountedDisplayConnected() { return default; }
	///<summary>Switches to/from using HMD and stereo rendering.</summary>
	public static bool EnableHMD(bool bEnable) { return default; }
	///<summary>Returns the name of the device, so scripts can modify their behaviour appropriately</summary>
	public static string GetHMDDeviceName() { return default; }
	///<summary>Returns the flags for the device, so scripts can modify their behaviour appropriately</summary>
	public static int GetXRSystemFlags() { return default; }
	///<summary>Returns name of tracking system specific version string.</summary>
	public static string GetVersionString() { return default; }
	///<summary>Returns the worn state of the device.</summary>
	public static EHMDWornState GetHMDWornState() { return default; }
	///<summary>Grabs the current orientation and position for the HMD.  If positional tracking is not available, DevicePosition will be a zero vector</summary>
	public static void GetOrientationAndPosition(FRotator DeviceRotation,FVector DevicePosition) {}
	///<summary>If the HMD supports positional tracking, whether or not we are currently being tracked</summary>
	public static bool HasValidTrackingPosition() { return default; }
	///<summary>If the HMD has multiple positional tracking sensors, return a total number of them currently connected.</summary>
	public static int GetNumOfTrackingSensors() { return default; }
	///<summary>If the HMD has a positional sensor, this will return the game-world location of it, as well as the parameters for the bounding region of tracking.</summary>
	public static void GetTrackingSensorParameters(FVector Origin,FRotator Rotation,float LeftFOV,float RightFOV,float TopFOV,float BottomFOV,float Distance,float NearPlane,float FarPlane,bool IsActive,int Index/*=0*/) {}
	///<summary>If the HMD has a positional sensor, this will return the game-world location of it, as well as the parameters for the bounding region of tracking.</summary>
	public static void GetPositionalTrackingCameraParameters(FVector CameraOrigin,FRotator CameraRotation,float HFOV,float VFOV,float CameraDistance,float NearPlane,float FarPlane) {}
	///<summary>Returns true, if HMD is in low persistence mode. &#39;false&#39; otherwise.</summary>
	public static bool IsInLowPersistenceMode() { return default; }
	///<summary>Switches between low and full persistence modes.</summary>
	public static void EnableLowPersistenceMode(bool bEnable) {}
	///<summary>Resets orientation by setting roll and pitch to 0, assuming that current yaw is forward direction and assuming</summary>
	public static void ResetOrientationAndPosition(float Yaw/*=0.0f*/,EOrientPositionSelector Options/*=EOrientPositionSelector.OrientationAndPosition*/) {}
	///<summary>Sets near and far clipping planes (NCP and FCP) for stereo rendering. Similar to &#39;stereo ncp= fcp&#39; console command, but NCP and FCP set by this</summary>
	public static void SetClippingPlanes(float Near,float Far) {}
	///<summary>Returns the current VR pixel density. Pixel density sets the VR render</summary>
	public static float GetPixelDensity() { return default; }
	///<summary>Sets the World to Meters scale, which changes the scale of the world as perceived by the player</summary>
	public static void SetWorldToMetersScale(UObject WorldContext,float NewScale/*=100.0f*/) {}
	///<summary>Returns the World to Meters scale, which corresponds to the scale of the world as perceived by the player</summary>
	public static float GetWorldToMetersScale(UObject WorldContext) { return default; }
	///<summary>Sets current tracking origin type (eye level or floor level).</summary>
	public static void SetTrackingOrigin(EHMDTrackingOrigin Origin) {}
	///<summary>Returns current tracking origin type (eye level or floor level).</summary>
	public static EHMDTrackingOrigin GetTrackingOrigin() { return default; }
	///<summary>Returns a transform that can be used to convert points from tracking space to world space.</summary>
	public static FTransform GetTrackingToWorldTransform(UObject WorldContext) { return default; }
	///<summary>Called to calibrate the offset transform between an external tracking source and the internal tracking source</summary>
	public static void CalibrateExternalTrackingToHMD(FTransform ExternalTrackingTransform) {}
	///<summary>Called after calibration to attempt to pull the internal tracker (e.g. HMD tracking) in line with the external tracker</summary>
	public static void UpdateExternalTrackingHMDPosition(FTransform ExternalTrackingTransform) {}
	///<summary>Returns current state of VR focus.</summary>
	public static void GetVRFocusState(bool bUseFocus,bool bHasFocus) {}
	///<summary>Return true if spectator screen mode control is available.</summary>
	public static bool IsSpectatorScreenModeControllable() { return default; }
	///<summary>Sets the social screen mode.</summary>
	public static void SetSpectatorScreenMode(ESpectatorScreenMode Mode) {}
	///<summary>Change the texture displayed on the social screen</summary>
	public static void SetSpectatorScreenTexture(UTexture InTexture) {}
	///<summary>Setup the layout for ESpectatorScreenMode::TexturePlusEye.</summary>
	public static void SetSpectatorScreenModeTexturePlusEyeLayout(FVector2D EyeRectMin,FVector2D EyeRectMax,FVector2D TextureRectMin,FVector2D TextureRectMax,bool bDrawEyeFirst/*=true*/,bool bClearBlack/*=false*/,bool bUseAlpha/*=false*/) {}
	///<summary>Cross XR-System query that will list all XR devices currently being tracked.</summary>
	public static TArray<FXRDeviceId> EnumerateTrackedDevices(string SystemId/*=NAME_None*/,EXRTrackedDeviceType DeviceType/*=EXRTrackedDeviceType.Any*/) { return default; }
	///<summary>Cross XR-System query that returns a specific device&#39;s tracked position and orientation (in tracking space).</summary>
	public static void GetDevicePose(FXRDeviceId XRDeviceId,bool bIsTracked,FRotator Orientation,bool bHasPositionalTracking,FVector Position) {}
	///<summary>Cross XR-System query that returns a specific device&#39;s position and orientation in world space.</summary>
	public static void GetDeviceWorldPose(UObject WorldContext,FXRDeviceId XRDeviceId,bool bIsTracked,FRotator Orientation,bool bHasPositionalTracking,FVector Position) {}
	///<summary>Cross XR-System query that returns whether the specified device is tracked or not.</summary>
	public static bool IsDeviceTracking(FXRDeviceId XRDeviceId) { return default; }
	///<summary>Cross XR-System query that returns critical information about the HMD display (position, orientation, device name)</summary>
	public static void GetHMDData(UObject WorldContext,FXRHMDData HMDData) {}
	///<summary>Cross XR-System query that returns critical information about the motion controller (position, orientation, hand/finger position)</summary>
	public static void GetMotionControllerData(UObject WorldContext,EControllerHand Hand,FXRMotionControllerData MotionControllerData) {}
	///<summary>Specify which gestures to capture.</summary>
	public static bool ConfigureGestures(FXRGestureConfig GestureConfig) { return default; }
	///<summary>Get the openXR interaction profile name for the given controller. Returns true if the openxr call is successfully made.  The string may be empty</summary>
	public static bool GetCurrentInteractionProfile(EControllerHand Hand,string InteractionProfile) { return default; }
	///<summary>Connect to a remote device</summary>
	public static EXRDeviceConnectionResult ConnectRemoteXRDevice(string IpAddress,int BitRate) { return default; }
	///<summary>Disconnect remote AR Device</summary>
	public static void DisconnectRemoteXRDevice() {}
	///<summary>SetXRDisconnectDelegate</summary>
	public static void SetXRDisconnectDelegate(FXRDeviceOnDisconnectDelegate InDisconnectedDelegate) {}
	///<summary>Hook up a delegate to get an OpenXR action event with action time.</summary>
	public static void SetXRTimedInputActionDelegate(string ActionName,FXRTimedInputActionDelegate InDelegate) {}
	///<summary>/ Clear a delegate to get an OpenXR action event with action time.</summary>
	public static void ClearXRTimedInputActionDelegate(string ActionPath) {}
	///<summary>Get the transform and potentially velocity data at a specified time near the current frame in unreal world space.</summary>
	public static bool GetControllerTransformForTime(UObject WorldContext,int ControllerIndex,string MotionSource,FTimespan Time,bool bTimeWasUsed,FRotator Orientation,FVector Position,bool bProvidedLinearVelocity,FVector LinearVelocity,bool bProvidedAngularVelocity,FVector AngularVelocityRadPerSec,bool bProvidedLinearAcceleration,FVector LinearAcceleration) { return default; }
	///<summary>Get the bounds of the area where the user can freely move while remaining tracked centered around the specified origin</summary>
	public static FVector2D GetPlayAreaBounds(EHMDTrackingOrigin Origin/*=EHMDTrackingOrigin.Stage*/) { return default; }
	///<summary>Get the transform of the specified tracking origin, if available.</summary>
	public static bool GetTrackingOriginTransform(EHMDTrackingOrigin Origin,FTransform OutTransform) { return default; }
	///<summary>Get the transform and dimensions of the playable area rectangle.  Returns false if none currently specified/available.</summary>
	public static bool GetPlayAreaRect(FTransform OutTransform,FVector2D OutRect) { return default; }
	///<summary>Breaks an XR key apart into the interaction profile, handedness, motion source, indentifier and component.</summary>
	public static void BreakKey(FKey InKey,string InteractionProfile,EControllerHand Hand,string MotionSource,string Indentifier,string Component) {}
}
