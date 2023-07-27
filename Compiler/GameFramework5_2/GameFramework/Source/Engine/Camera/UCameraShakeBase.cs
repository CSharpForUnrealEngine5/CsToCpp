#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Camera/CameraShakeBase.h")]
///<summary>Base class for a camera shake. A camera shake contains a root shake "pattern" which is</summary>
public partial class UCameraShakeBase : UObject {
// CameraShakeBase
	public bool bSingleInstance;
	public float ShakeScale;
	public  UCameraShakePattern GetRootShakePattern() { return default; }
	public  void SetRootShakePattern(UCameraShakePattern InPattern) {}
	public UCameraShakePattern RootShakePattern;
	public APlayerCameraManager CameraManager;
}
