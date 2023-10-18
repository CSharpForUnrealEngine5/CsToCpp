namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint function library for autocasting a player camera manager into the camera animation camera modifier.</summary>
[CppInclude("CameraAnimationCameraModifier.h")]
public partial class UGameplayCamerasFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Conv_CameraAnimationCameraModifier</summary>
	public static UCameraAnimationCameraModifier Conv_CameraAnimationCameraModifier(APlayerCameraManager PlayerCameraManager) { return default; }
	///<summary>Conv_CameraShakePlaySpace</summary>
	public static ECameraShakePlaySpace Conv_CameraShakePlaySpace(ECameraAnimationPlaySpace CameraAnimationPlaySpace) { return default; }
	///<summary>Conv_CameraAnimationPlaySpace</summary>
	public static ECameraAnimationPlaySpace Conv_CameraAnimationPlaySpace(ECameraShakePlaySpace CameraShakePlaySpace) { return default; }
}
