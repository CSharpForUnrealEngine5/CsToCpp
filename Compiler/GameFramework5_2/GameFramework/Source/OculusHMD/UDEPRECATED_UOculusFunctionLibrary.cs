#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusFunctionLibrary.h")]
public partial class UDEPRECATED_UOculusFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>GetPose</summary>
	public static void GetPose(FRotator DeviceRotation,FVector DevicePosition,FVector NeckPosition,bool bUseOrienationForPlayerCamera/*=false*/,bool bUsePositionForPlayerCamera/*=false*/,FVector PositionScale/*=FVector.ZeroVector*/) {}
	///<summary>GetRawSensorData</summary>
	public static void GetRawSensorData(FVector AngularAcceleration,FVector LinearAcceleration,FVector AngularVelocity,FVector LinearVelocity,float TimeInSeconds,ETrackedDeviceType DeviceType/*=ETrackedDeviceType.HMD*/) {}
	///<summary>IsDeviceTracked</summary>
	public static bool IsDeviceTracked(ETrackedDeviceType DeviceType) { return default; }
	///<summary>SetCPUAndGPULevels</summary>
	public static void SetCPUAndGPULevels(int CPULevel,int GPULevel) {}
	///<summary>GetUserProfile</summary>
	public static bool GetUserProfile(FHmdUserProfile Profile) { return default; }
	///<summary>SetBaseRotationAndBaseOffsetInMeters</summary>
	public static void SetBaseRotationAndBaseOffsetInMeters(FRotator Rotation,FVector BaseOffsetInMeters,EOrientPositionSelector Options) {}
	///<summary>GetBaseRotationAndBaseOffsetInMeters</summary>
	public static void GetBaseRotationAndBaseOffsetInMeters(FRotator OutRotation,FVector OutBaseOffsetInMeters) {}
	///<summary>SetPositionScale3D</summary>
	public static void SetPositionScale3D(FVector PosScale3D) {}
	///<summary>SetBaseRotationAndPositionOffset</summary>
	public static void SetBaseRotationAndPositionOffset(FRotator BaseRot,FVector PosOffset,EOrientPositionSelector Options) {}
	///<summary>GetBaseRotationAndPositionOffset</summary>
	public static void GetBaseRotationAndPositionOffset(FRotator OutRot,FVector OutPosOffset) {}
	///<summary>AddLoadingSplashScreen</summary>
	public static void AddLoadingSplashScreen(UTexture2D Texture,FVector TranslationInMeters,FRotator Rotation,FVector2D SizeInMeters/*=new FVector2D(1.0f,1.0f)*/,FRotator DeltaRotation/*=FRotator.ZeroRotator*/,bool bClearBeforeAdd/*=false*/) {}
	///<summary>ClearLoadingSplashScreens</summary>
	public static void ClearLoadingSplashScreens() {}
	///<summary>HasInputFocus</summary>
	public static bool HasInputFocus() { return default; }
	///<summary>HasSystemOverlayPresent</summary>
	public static bool HasSystemOverlayPresent() { return default; }
	///<summary>GetGPUUtilization</summary>
	public static void GetGPUUtilization(bool IsGPUAvailable,float GPUUtilization) {}
	///<summary>GetGPUFrameTime</summary>
	public static float GetGPUFrameTime() { return default; }
	///<summary>GetFixedFoveatedRenderingLevel</summary>
	public static EFixedFoveatedRenderingLevel GetFixedFoveatedRenderingLevel() { return default; }
	///<summary>SetFixedFoveatedRenderingLevel</summary>
	public static void SetFixedFoveatedRenderingLevel(EFixedFoveatedRenderingLevel level,bool isDynamic) {}
	///<summary>GetDeviceName</summary>
	public static string GetDeviceName() { return default; }
	///<summary>GetDeviceType</summary>
	public static EOculusDeviceType GetDeviceType() { return default; }
	///<summary>GetAvailableDisplayFrequencies</summary>
	public static TArray<float> GetAvailableDisplayFrequencies() { return default; }
	///<summary>GetCurrentDisplayFrequency</summary>
	public static float GetCurrentDisplayFrequency() { return default; }
	///<summary>SetDisplayFrequency</summary>
	public static void SetDisplayFrequency(float RequestedFrequency) {}
	///<summary>EnablePositionTracking</summary>
	public static void EnablePositionTracking(bool bPositionTracking) {}
	///<summary>EnableOrientationTracking</summary>
	public static void EnableOrientationTracking(bool bOrientationTracking) {}
	///<summary>SetColorScaleAndOffset</summary>
	public static void SetColorScaleAndOffset(FLinearColor ColorScale,FLinearColor ColorOffset,bool bApplyToAllLayers/*=false*/) {}
	///<summary>GetSystemHmd3DofModeEnabled</summary>
	public static bool GetSystemHmd3DofModeEnabled() { return default; }
	///<summary>GetHmdColorDesc</summary>
	public static EOculusColorSpace GetHmdColorDesc() { return default; }
	///<summary>SetClientColorDesc</summary>
	public static void SetClientColorDesc(EOculusColorSpace ColorSpace) {}
	///<summary>IsGuardianDisplayed</summary>
	public static bool IsGuardianDisplayed() { return default; }
	///<summary>IsGuardianConfigured</summary>
	public static bool IsGuardianConfigured() { return default; }
	///<summary>GetGuardianPoints</summary>
	public static TArray<FVector> GetGuardianPoints(EBoundaryType BoundaryType,bool UsePawnSpace/*=false*/) { return default; }
	///<summary>GetGuardianDimensions</summary>
	public static FVector GetGuardianDimensions(EBoundaryType BoundaryType) { return default; }
	///<summary>GetPlayAreaTransform</summary>
	public static FTransform GetPlayAreaTransform() { return default; }
	///<summary>GetPointGuardianIntersection</summary>
	public static FGuardianTestResult GetPointGuardianIntersection(FVector Point,EBoundaryType BoundaryType) { return default; }
	///<summary>GetNodeGuardianIntersection</summary>
	public static FGuardianTestResult GetNodeGuardianIntersection(ETrackedDeviceType DeviceType,EBoundaryType BoundaryType) { return default; }
	///<summary>SetGuardianVisibility</summary>
	public static void SetGuardianVisibility(bool GuardianVisible) {}
}
