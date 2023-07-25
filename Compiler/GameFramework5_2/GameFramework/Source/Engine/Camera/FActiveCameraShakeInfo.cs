#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Camera/CameraModifier_CameraShake.h")]
///<summary>Information about an active camera shake.</summary>
public partial struct FActiveCameraShakeInfo {
// ActiveCameraShakeInfo
	public UCameraShakeBase ShakeInstance;
	public TWeakObjectPtr<UCameraShakeSourceComponent> ShakeSource;
	public bool bIsCustomInitialized;
}
