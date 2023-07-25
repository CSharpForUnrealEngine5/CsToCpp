#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HeadMountedDisplayFunctionLibrary.h")]
public partial class UHeadMountedDisplayFunctionLibrary : UBlueprintFunctionLibrary {
// HeadMountedDisplayFunctionLibrary
	public bool IsHeadMountedDisplayEnabled() { return default; }
	public bool IsHeadMountedDisplayConnected() { return default; }
	public bool EnableHMD(bool bEnable) { return default; }
	public string GetHMDDeviceName() { return default; }
	public int GetXRSystemFlags() { return default; }
	public string GetVersionString() { return default; }
	public EHMDWornState GetHMDWornState() { return default; }
	public void GetOrientationAndPosition(FRotator DeviceRotation,FVector DevicePosition) {}
	public bool HasValidTrackingPosition() { return default; }
	public int GetNumOfTrackingSensors() { return default; }
	public void GetTrackingSensorParameters(FVector Origin,FRotator Rotation,float LeftFOV,float RightFOV,float TopFOV,float BottomFOV,float Distance,float NearPlane,float FarPlane,bool IsActive,int Index/*=0*/) {}
	public void GetPositionalTrackingCameraParameters(FVector CameraOrigin,FRotator CameraRotation,float HFOV,float VFOV,float CameraDistance,float NearPlane,float FarPlane) {}
	public bool IsInLowPersistenceMode() { return default; }
	public void EnableLowPersistenceMode(bool bEnable) {}
	public void ResetOrientationAndPosition(float Yaw/*=0.0f*/,EOrientPositionSelector Options/*=EOrientPositionSelector.OrientationAndPosition*/) {}
	public void SetClippingPlanes(float Near,float Far) {}
	public float GetPixelDensity() { return default; }
	public void SetWorldToMetersScale(UObject WorldContext,float NewScale/*=100.0f*/) {}
	public float GetWorldToMetersScale(UObject WorldContext) { return default; }
	public void SetTrackingOrigin(byte Origin) {}
	public byte GetTrackingOrigin() { return default; }
	public FTransform GetTrackingToWorldTransform(UObject WorldContext) { return default; }
	public void CalibrateExternalTrackingToHMD(FTransform ExternalTrackingTransform) {}
	public void UpdateExternalTrackingHMDPosition(FTransform ExternalTrackingTransform) {}
	public void GetVRFocusState(bool bUseFocus,bool bHasFocus) {}
	public bool IsSpectatorScreenModeControllable() { return default; }
	public void SetSpectatorScreenMode(ESpectatorScreenMode Mode) {}
	public void SetSpectatorScreenTexture(UObject InTexture) {}
	public void SetSpectatorScreenModeTexturePlusEyeLayout(FVector2D EyeRectMin,FVector2D EyeRectMax,FVector2D TextureRectMin,FVector2D TextureRectMax,bool bDrawEyeFirst/*=true*/,bool bClearBlack/*=false*/,bool bUseAlpha/*=false*/) {}
	public TArray<FXRDeviceId> EnumerateTrackedDevices(string SystemId/*=NAME_None*/,EXRTrackedDeviceType DeviceType/*=EXRTrackedDeviceType.Any*/) { return default; }
	public void GetDevicePose(FXRDeviceId XRDeviceId,bool bIsTracked,FRotator Orientation,bool bHasPositionalTracking,FVector Position) {}
	public void GetDeviceWorldPose(UObject WorldContext,FXRDeviceId XRDeviceId,bool bIsTracked,FRotator Orientation,bool bHasPositionalTracking,FVector Position) {}
	public bool IsDeviceTracking(FXRDeviceId XRDeviceId) { return default; }
	public void GetHMDData(UObject WorldContext,FXRHMDData HMDData) {}
	public void GetMotionControllerData(UObject WorldContext,EControllerHand Hand,FXRMotionControllerData MotionControllerData) {}
	public bool ConfigureGestures(FXRGestureConfig GestureConfig) { return default; }
	public bool GetCurrentInteractionProfile(EControllerHand Hand,string InteractionProfile) { return default; }
	public EXRDeviceConnectionResult ConnectRemoteXRDevice(string IpAddress,int BitRate) { return default; }
	public void DisconnectRemoteXRDevice() {}
	public void SetXRDisconnectDelegate(FXRDeviceOnDisconnectDelegate InDisconnectedDelegate) {}
	public void SetXRTimedInputActionDelegate(string ActionName,FXRTimedInputActionDelegate InDelegate) {}
	public void ClearXRTimedInputActionDelegate(string ActionPath) {}
	public bool GetControllerTransformForTime(UObject WorldContext,int ControllerIndex,string MotionSource,FTimespan Time,bool bTimeWasUsed,FRotator Orientation,FVector Position,bool bProvidedLinearVelocity,FVector LinearVelocity,bool bProvidedAngularVelocity,FVector AngularVelocityRadPerSec,bool bProvidedLinearAcceleration,FVector LinearAcceleration) { return default; }
	public FVector2D GetPlayAreaBounds(byte Origin/*=EHMDTrackingOrigin.Stage*/) { return default; }
	public bool GetTrackingOriginTransform(byte Origin,FTransform OutTransform) { return default; }
	public bool GetPlayAreaRect(FTransform OutTransform,FVector2D OutRect) { return default; }
	public void BreakKey(FKey InKey,string InteractionProfile,EControllerHand Hand,string MotionSource,string Indentifier,string Component) {}
}
