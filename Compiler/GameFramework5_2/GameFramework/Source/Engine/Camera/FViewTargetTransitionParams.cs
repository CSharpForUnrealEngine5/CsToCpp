#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Camera/PlayerCameraManager.h")]
///<summary>A set of parameters to describe how to transition between view targets.</summary>
public partial struct FViewTargetTransitionParams {
// ViewTargetTransitionParams
	public float BlendTime;
	public byte BlendFunction;
	public float BlendExp;
	public bool bLockOutgoing;
}
