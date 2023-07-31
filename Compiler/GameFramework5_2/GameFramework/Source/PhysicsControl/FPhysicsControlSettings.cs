#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>General settings for a control</summary>
[CppInclude("PhysicsControlData.h")]
public partial struct FPhysicsControlSettings {
	public FVector ControlPoint;
	public bool bUseSkeletalAnimation;
	public float SkeletalAnimationVelocityMultiplier;
	public bool bDisableCollision;
	public bool bAutoDisable;
}
