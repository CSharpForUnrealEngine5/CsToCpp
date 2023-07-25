#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Camera/CameraShakeBase.h")]
///<summary>Base class for a camera shake. A camera shake contains a root shake "pattern" which is</summary>
public partial class UCameraShakeBase : UObject {
// CameraShakeBase
	public bool bSingleInstance;
	public float ShakeScale;
	public UObject GetRootShakePattern() { return default; }
	public void SetRootShakePattern(UObject InPattern) {}
	public UCameraShakePattern RootShakePattern;
	public APlayerCameraManager CameraManager;
}
