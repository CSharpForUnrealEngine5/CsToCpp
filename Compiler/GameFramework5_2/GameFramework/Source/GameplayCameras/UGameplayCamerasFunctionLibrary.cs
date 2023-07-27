#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CameraAnimationCameraModifier.h")]
///<summary>Blueprint function library for autocasting a player camera manager into the camera animation camera modifier.</summary>
public partial class UGameplayCamerasFunctionLibrary : UBlueprintFunctionLibrary {
// GameplayCamerasFunctionLibrary
	public static UCameraAnimationCameraModifier Conv_CameraAnimationCameraModifier(APlayerCameraManager PlayerCameraManager) { return default; }
	public static ECameraShakePlaySpace Conv_CameraShakePlaySpace(ECameraAnimationPlaySpace CameraAnimationPlaySpace) { return default; }
	public static ECameraAnimationPlaySpace Conv_CameraAnimationPlaySpace(ECameraShakePlaySpace CameraShakePlaySpace) { return default; }
}
