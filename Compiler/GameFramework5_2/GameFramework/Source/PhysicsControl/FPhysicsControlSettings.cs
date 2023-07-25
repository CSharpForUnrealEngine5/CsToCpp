#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsControlData.h")]
///<summary>General settings for a control</summary>
public partial struct FPhysicsControlSettings {
// PhysicsControlSettings
	public FVector ControlPoint;
	public bool bUseSkeletalAnimation;
	public float SkeletalAnimationVelocityMultiplier;
	public bool bDisableCollision;
	public bool bAutoDisable;
}
