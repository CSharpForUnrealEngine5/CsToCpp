#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusFunctionLibrary.h")]
public partial class UDEPRECATED_UOculusFunctionLibrary : UBlueprintFunctionLibrary {
// UOculusFunctionLibrary
	public void GetPose(FRotator DeviceRotation,FVector DevicePosition,FVector NeckPosition,bool bUseOrienationForPlayerCamera/*=false*/,bool bUsePositionForPlayerCamera/*=false*/,FVector PositionScale/*=FVector.ZeroVector*/) {}
	public void GetRawSensorData(FVector AngularAcceleration,FVector LinearAcceleration,FVector AngularVelocity,FVector LinearVelocity,float TimeInSeconds,ETrackedDeviceType DeviceType/*=ETrackedDeviceType.HMD*/) {}
	public bool IsDeviceTracked(ETrackedDeviceType DeviceType) { return default; }
	public void SetCPUAndGPULevels(int CPULevel,int GPULevel) {}
	public bool GetUserProfile(FHmdUserProfile Profile) { return default; }
	public void SetBaseRotationAndBaseOffsetInMeters(FRotator Rotation,FVector BaseOffsetInMeters,EOrientPositionSelector Options) {}
	public void GetBaseRotationAndBaseOffsetInMeters(FRotator OutRotation,FVector OutBaseOffsetInMeters) {}
	public void SetPositionScale3D(FVector PosScale3D) {}
	public void SetBaseRotationAndPositionOffset(FRotator BaseRot,FVector PosOffset,EOrientPositionSelector Options) {}
	public void GetBaseRotationAndPositionOffset(FRotator OutRot,FVector OutPosOffset) {}
	public void AddLoadingSplashScreen(UObject Texture,FVector TranslationInMeters,FRotator Rotation,FVector2D SizeInMeters/*=new FVector2D(1.0f,1.0f)*/,FRotator DeltaRotation/*=FRotator.ZeroRotator*/,bool bClearBeforeAdd/*=false*/) {}
	public void ClearLoadingSplashScreens() {}
	public bool HasInputFocus() { return default; }
	public bool HasSystemOverlayPresent() { return default; }
	public void GetGPUUtilization(bool IsGPUAvailable,float GPUUtilization) {}
	public float GetGPUFrameTime() { return default; }
	public EFixedFoveatedRenderingLevel GetFixedFoveatedRenderingLevel() { return default; }
	public void SetFixedFoveatedRenderingLevel(EFixedFoveatedRenderingLevel level,bool isDynamic) {}
	public string GetDeviceName() { return default; }
	public EOculusDeviceType GetDeviceType() { return default; }
	public TArray<float> GetAvailableDisplayFrequencies() { return default; }
	public float GetCurrentDisplayFrequency() { return default; }
	public void SetDisplayFrequency(float RequestedFrequency) {}
	public void EnablePositionTracking(bool bPositionTracking) {}
	public void EnableOrientationTracking(bool bOrientationTracking) {}
	public void SetColorScaleAndOffset(FLinearColor ColorScale,FLinearColor ColorOffset,bool bApplyToAllLayers/*=false*/) {}
	public bool GetSystemHmd3DofModeEnabled() { return default; }
	public EOculusColorSpace GetHmdColorDesc() { return default; }
	public void SetClientColorDesc(EOculusColorSpace ColorSpace) {}
	public bool IsGuardianDisplayed() { return default; }
	public bool IsGuardianConfigured() { return default; }
	public TArray<FVector> GetGuardianPoints(EBoundaryType BoundaryType,bool UsePawnSpace/*=false*/) { return default; }
	public FVector GetGuardianDimensions(EBoundaryType BoundaryType) { return default; }
	public FTransform GetPlayAreaTransform() { return default; }
	public FGuardianTestResult GetPointGuardianIntersection(FVector Point,EBoundaryType BoundaryType) { return default; }
	public FGuardianTestResult GetNodeGuardianIntersection(ETrackedDeviceType DeviceType,EBoundaryType BoundaryType) { return default; }
	public void SetGuardianVisibility(bool GuardianVisible) {}
}
