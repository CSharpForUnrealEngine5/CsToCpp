#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for a camera shake. A camera shake contains a root shake &quot;pattern&quot; which is</summary>
[CppInclude("Camera/CameraShakeBase.h")]
public partial class UCameraShakeBase : UObject {
	///<summary>If true to only allow a single instance of this shake class to play at any given time.</summary>
	public bool bSingleInstance;
	///<summary>The overall scale to apply to the shake. Only valid when the shake is active.</summary>
	public float ShakeScale;
	///<summary>Gets the root pattern of this camera shake</summary>
	public  UCameraShakePattern GetRootShakePattern() { return default; }
	///<summary>Sets the root pattern of this camera shake</summary>
	public  void SetRootShakePattern(UCameraShakePattern InPattern) {}
	///<summary>The root pattern for this camera shake</summary>
	public UCameraShakePattern RootShakePattern;
	///<summary>The camera manager owning this camera shake. Only valid when the shake is active.</summary>
	public APlayerCameraManager CameraManager;
}
