#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicsConstraintTemplate.h")]
public partial class UPhysicsConstraintTemplate : UObject {
// PhysicsConstraintTemplate
	public FConstraintInstance DefaultInstance;
	public TArray<FPhysicsConstraintProfileHandle> ProfileHandles;
	public FConstraintProfileProperties DefaultProfile;
	public string JointName_DEPRECATED;
	public string ConstraintBone1_DEPRECATED;
	public string ConstraintBone2_DEPRECATED;
	public FVector Pos1_DEPRECATED;
	public FVector PriAxis1_DEPRECATED;
	public FVector SecAxis1_DEPRECATED;
	public FVector Pos2_DEPRECATED;
	public FVector PriAxis2_DEPRECATED;
	public FVector SecAxis2_DEPRECATED;
	public bool bEnableProjection_DEPRECATED;
	public float ProjectionLinearTolerance_DEPRECATED;
	public float ProjectionAngularTolerance_DEPRECATED;
	public byte LinearXMotion_DEPRECATED;
	public byte LinearYMotion_DEPRECATED;
	public byte LinearZMotion_DEPRECATED;
	public float LinearLimitSize_DEPRECATED;
	public bool bLinearLimitSoft_DEPRECATED;
	public float LinearLimitStiffness_DEPRECATED;
	public float LinearLimitDamping_DEPRECATED;
	public bool bLinearBreakable_DEPRECATED;
	public float LinearBreakThreshold_DEPRECATED;
	public byte AngularSwing1Motion_DEPRECATED;
	public byte AngularSwing2Motion_DEPRECATED;
	public byte AngularTwistMotion_DEPRECATED;
	public bool bSwingLimitSoft_DEPRECATED;
	public bool bTwistLimitSoft_DEPRECATED;
	public float Swing1LimitAngle_DEPRECATED;
	public float Swing2LimitAngle_DEPRECATED;
	public float TwistLimitAngle_DEPRECATED;
	public float SwingLimitStiffness_DEPRECATED;
	public float SwingLimitDamping_DEPRECATED;
	public float TwistLimitStiffness_DEPRECATED;
	public float TwistLimitDamping_DEPRECATED;
	public bool bAngularBreakable_DEPRECATED;
	public float AngularBreakThreshold_DEPRECATED;
}
