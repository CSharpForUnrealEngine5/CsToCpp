namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about a camera shake class.</summary>
[CppInclude("Camera/CameraShakeBase.h")]
public partial struct FCameraShakeInfo {
	public FCameraShakeDuration Duration;
	public float BlendIn;
	public float BlendOut;
}
