namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct for RootMotion Finish Velocity options.</summary>
[CppInclude("GameFramework/RootMotionSource.h")]
public partial struct FRootMotionFinishVelocitySettings {
	public ERootMotionFinishVelocityMode Mode;
	public FVector SetVelocity;
	public float ClampVelocity;
}
