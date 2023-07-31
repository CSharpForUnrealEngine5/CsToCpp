#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct for RootMotion Finish Velocity options.</summary>
[CppInclude("GameFramework/RootMotionSource.h")]
public partial struct FRootMotionFinishVelocitySettings {
	public ERootMotionFinishVelocityMode Mode;
	public FVector SetVelocity;
	public float ClampVelocity;
}
