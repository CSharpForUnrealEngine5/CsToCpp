namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about an active camera shake.</summary>
[CppInclude("Camera/CameraModifier_CameraShake.h")]
public partial struct FActiveCameraShakeInfo {
	public UCameraShakeBase ShakeInstance;
	public TWeakObjectPtr<UCameraShakeSourceComponent> ShakeSource;
	public bool bIsCustomInitialized;
}
