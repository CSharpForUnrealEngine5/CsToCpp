#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HeadMountedDisplayFunctionLibrary.h")]
public partial class UHeadMountedDisplayFunctionLibrary : UBlueprintFunctionLibrary {
// HeadMountedDisplayFunctionLibrary
	public static bool IsHeadMountedDisplayEnabled() { return default; }
	public static bool IsHeadMountedDisplayConnected() { return default; }
	public static bool EnableHMD(bool bEnable) { return default; }
	public static string GetHMDDeviceName() { return default; }
	public static int GetXRSystemFlags() { return default; }
	public static string GetVersionString() { return default; }
	public static EHMDWornState GetHMDWornState() { return default; }
	public static void GetOrientationAndPosition(FRotator DeviceRotation,FVector DevicePosition) {}
	public static bool HasValidTrackingPosition() { return default; }
	public static int GetNumOfTrackingSensors() { return default; }
	public static void GetTrackingSensorParameters(FVector Origin,FRotator Rotation,float LeftFOV,float RightFOV,float TopFOV,float BottomFOV,float Distance,float NearPlane,float FarPlane,bool IsActive,int Index/*=0*/) {}
	public static void GetPositionalTrackingCameraParameters(FVector CameraOrigin,FRotator CameraRotation,float HFOV,float VFOV,float CameraDistance,float NearPlane,float FarPlane) {}
	public static bool IsInLowPersistenceMode() { return default; }
	public static void EnableLowPersistenceMode(bool bEnable) {}
	public static void ResetOrientationAndPosition(float Yaw/*=0.0f*/,EOrientPositionSelector Options/*=EOrientPositionSelector.OrientationAndPosition*/) {}
	public static void SetClippingPlanes(float Near,float Far) {}
	public static float GetPixelDensity() { return default; }
	public static void SetWorldToMetersScale(UObject WorldContext,float NewScale/*=100.0f*/) {}
	public static float GetWorldToMetersScale(UObject WorldContext) { return default; }
	public static void SetTrackingOrigin(EHMDTrackingOrigin Origin) {}
	public static EHMDTrackingOrigin GetTrackingOrigin() { return default; }
	public static FTransform GetTrackingToWorldTransform(UObject WorldContext) { return default; }
	public static void CalibrateExternalTrackingToHMD(FTransform ExternalTrackingTransform) {}
	public static void UpdateExternalTrackingHMDPosition(FTransform ExternalTrackingTransform) {}
	public static void GetVRFocusState(bool bUseFocus,bool bHasFocus) {}
	public static bool IsSpectatorScreenModeControllable() { return default; }
	public static void SetSpectatorScreenMode(ESpectatorScreenMode Mode) {}
	public static void SetSpectatorScreenTexture(UTexture InTexture) {}
	public static void SetSpectatorScreenModeTexturePlusEyeLayout(FVector2D EyeRectMin,FVector2D EyeRectMax,FVector2D TextureRectMin,FVector2D TextureRectMax,bool bDrawEyeFirst/*=true*/,bool bClearBlack/*=false*/,bool bUseAlpha/*=false*/) {}
	public static TArray<FXRDeviceId> EnumerateTrackedDevices(string SystemId/*=NAME_None*/,EXRTrackedDeviceType DeviceType/*=EXRTrackedDeviceType.Any*/) { return default; }
	public static void GetDevicePose(FXRDeviceId XRDeviceId,bool bIsTracked,FRotator Orientation,bool bHasPositionalTracking,FVector Position) {}
	public static void GetDeviceWorldPose(UObject WorldContext,FXRDeviceId XRDeviceId,bool bIsTracked,FRotator Orientation,bool bHasPositionalTracking,FVector Position) {}
	public static bool IsDeviceTracking(FXRDeviceId XRDeviceId) { return default; }
	public static void GetHMDData(UObject WorldContext,FXRHMDData HMDData) {}
	public static void GetMotionControllerData(UObject WorldContext,EControllerHand Hand,FXRMotionControllerData MotionControllerData) {}
	public static bool ConfigureGestures(FXRGestureConfig GestureConfig) { return default; }
	public static bool GetCurrentInteractionProfile(EControllerHand Hand,string InteractionProfile) { return default; }
	public static EXRDeviceConnectionResult ConnectRemoteXRDevice(string IpAddress,int BitRate) { return default; }
	public static void DisconnectRemoteXRDevice() {}
	public static void SetXRDisconnectDelegate(FXRDeviceOnDisconnectDelegate InDisconnectedDelegate) {}
	public static void SetXRTimedInputActionDelegate(string ActionName,FXRTimedInputActionDelegate InDelegate) {}
	public static void ClearXRTimedInputActionDelegate(string ActionPath) {}
	public static bool GetControllerTransformForTime(UObject WorldContext,int ControllerIndex,string MotionSource,FTimespan Time,bool bTimeWasUsed,FRotator Orientation,FVector Position,bool bProvidedLinearVelocity,FVector LinearVelocity,bool bProvidedAngularVelocity,FVector AngularVelocityRadPerSec,bool bProvidedLinearAcceleration,FVector LinearAcceleration) { return default; }
	public static FVector2D GetPlayAreaBounds(EHMDTrackingOrigin Origin/*=EHMDTrackingOrigin.Stage*/) { return default; }
	public static bool GetTrackingOriginTransform(EHMDTrackingOrigin Origin,FTransform OutTransform) { return default; }
	public static bool GetPlayAreaRect(FTransform OutTransform,FVector2D OutRect) { return default; }
	public static void BreakKey(FKey InKey,string InteractionProfile,EControllerHand Hand,string MotionSource,string Indentifier,string Component) {}
}
