#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A set of parameters to describe how to transition between view targets.</summary>
[CppInclude("Camera/PlayerCameraManager.h")]
public partial struct FViewTargetTransitionParams {
	public float BlendTime;
	public EViewTargetBlendFunction BlendFunction;
	public float BlendExp;
	public bool bLockOutgoing;
}
