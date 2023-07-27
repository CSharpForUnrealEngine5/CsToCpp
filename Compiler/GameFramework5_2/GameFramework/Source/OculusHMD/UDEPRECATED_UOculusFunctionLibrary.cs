#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusFunctionLibrary.h")]
public partial class UDEPRECATED_UOculusFunctionLibrary : UBlueprintFunctionLibrary {
// UOculusFunctionLibrary
	public static void GetPose(FRotator DeviceRotation,FVector DevicePosition,FVector NeckPosition,bool bUseOrienationForPlayerCamera/*=false*/,bool bUsePositionForPlayerCamera/*=false*/,FVector PositionScale/*=FVector.ZeroVector*/) {}
	public static void GetRawSensorData(FVector AngularAcceleration,FVector LinearAcceleration,FVector AngularVelocity,FVector LinearVelocity,float TimeInSeconds,ETrackedDeviceType DeviceType/*=ETrackedDeviceType.HMD*/) {}
	public static bool IsDeviceTracked(ETrackedDeviceType DeviceType) { return default; }
	public static void SetCPUAndGPULevels(int CPULevel,int GPULevel) {}
	public static bool GetUserProfile(FHmdUserProfile Profile) { return default; }
	public static void SetBaseRotationAndBaseOffsetInMeters(FRotator Rotation,FVector BaseOffsetInMeters,EOrientPositionSelector Options) {}
	public static void GetBaseRotationAndBaseOffsetInMeters(FRotator OutRotation,FVector OutBaseOffsetInMeters) {}
	public static void SetPositionScale3D(FVector PosScale3D) {}
	public static void SetBaseRotationAndPositionOffset(FRotator BaseRot,FVector PosOffset,EOrientPositionSelector Options) {}
	public static void GetBaseRotationAndPositionOffset(FRotator OutRot,FVector OutPosOffset) {}
	public static void AddLoadingSplashScreen(UTexture2D Texture,FVector TranslationInMeters,FRotator Rotation,FVector2D SizeInMeters/*=new FVector2D(1.0f,1.0f)*/,FRotator DeltaRotation/*=FRotator.ZeroRotator*/,bool bClearBeforeAdd/*=false*/) {}
	public static void ClearLoadingSplashScreens() {}
	public static bool HasInputFocus() { return default; }
	public static bool HasSystemOverlayPresent() { return default; }
	public static void GetGPUUtilization(bool IsGPUAvailable,float GPUUtilization) {}
	public static float GetGPUFrameTime() { return default; }
	public static EFixedFoveatedRenderingLevel GetFixedFoveatedRenderingLevel() { return default; }
	public static void SetFixedFoveatedRenderingLevel(EFixedFoveatedRenderingLevel level,bool isDynamic) {}
	public static string GetDeviceName() { return default; }
	public static EOculusDeviceType GetDeviceType() { return default; }
	public static TArray<float> GetAvailableDisplayFrequencies() { return default; }
	public static float GetCurrentDisplayFrequency() { return default; }
	public static void SetDisplayFrequency(float RequestedFrequency) {}
	public static void EnablePositionTracking(bool bPositionTracking) {}
	public static void EnableOrientationTracking(bool bOrientationTracking) {}
	public static void SetColorScaleAndOffset(FLinearColor ColorScale,FLinearColor ColorOffset,bool bApplyToAllLayers/*=false*/) {}
	public static bool GetSystemHmd3DofModeEnabled() { return default; }
	public static EOculusColorSpace GetHmdColorDesc() { return default; }
	public static void SetClientColorDesc(EOculusColorSpace ColorSpace) {}
	public static bool IsGuardianDisplayed() { return default; }
	public static bool IsGuardianConfigured() { return default; }
	public static TArray<FVector> GetGuardianPoints(EBoundaryType BoundaryType,bool UsePawnSpace/*=false*/) { return default; }
	public static FVector GetGuardianDimensions(EBoundaryType BoundaryType) { return default; }
	public static FTransform GetPlayAreaTransform() { return default; }
	public static FGuardianTestResult GetPointGuardianIntersection(FVector Point,EBoundaryType BoundaryType) { return default; }
	public static FGuardianTestResult GetNodeGuardianIntersection(ETrackedDeviceType DeviceType,EBoundaryType BoundaryType) { return default; }
	public static void SetGuardianVisibility(bool GuardianVisible) {}
}
