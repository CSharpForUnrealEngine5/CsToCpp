namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicsConstraintTemplate.h")]
public partial class UPhysicsConstraintTemplate : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultInstance</summary>
	public FConstraintInstance DefaultInstance;
	///<summary>Handles to the constraint profiles applicable to this constraint</summary>
	public TArray<FPhysicsConstraintProfileHandle> ProfileHandles;
	///<summary>When no profile is selected, use these settings. Only needed in editor as we serialize it into DefaultInstance on save</summary>
	public FConstraintProfileProperties DefaultProfile;
	///<summary>JointName_DEPRECATED</summary>
	public FName JointName_DEPRECATED;
	///<summary>ConstraintBone1_DEPRECATED</summary>
	public FName ConstraintBone1_DEPRECATED;
	///<summary>ConstraintBone2_DEPRECATED</summary>
	public FName ConstraintBone2_DEPRECATED;
	///<summary>Pos1_DEPRECATED</summary>
	public FVector Pos1_DEPRECATED;
	///<summary>PriAxis1_DEPRECATED</summary>
	public FVector PriAxis1_DEPRECATED;
	///<summary>SecAxis1_DEPRECATED</summary>
	public FVector SecAxis1_DEPRECATED;
	///<summary>Pos2_DEPRECATED</summary>
	public FVector Pos2_DEPRECATED;
	///<summary>PriAxis2_DEPRECATED</summary>
	public FVector PriAxis2_DEPRECATED;
	///<summary>SecAxis2_DEPRECATED</summary>
	public FVector SecAxis2_DEPRECATED;
	///<summary>bEnableProjection_DEPRECATED</summary>
	public bool bEnableProjection_DEPRECATED;
	///<summary>ProjectionLinearTolerance_DEPRECATED</summary>
	public float ProjectionLinearTolerance_DEPRECATED;
	///<summary>ProjectionAngularTolerance_DEPRECATED</summary>
	public float ProjectionAngularTolerance_DEPRECATED;
	///<summary>LinearXMotion_DEPRECATED</summary>
	public ELinearConstraintMotion LinearXMotion_DEPRECATED;
	///<summary>LinearYMotion_DEPRECATED</summary>
	public ELinearConstraintMotion LinearYMotion_DEPRECATED;
	///<summary>LinearZMotion_DEPRECATED</summary>
	public ELinearConstraintMotion LinearZMotion_DEPRECATED;
	///<summary>LinearLimitSize_DEPRECATED</summary>
	public float LinearLimitSize_DEPRECATED;
	///<summary>bLinearLimitSoft_DEPRECATED</summary>
	public bool bLinearLimitSoft_DEPRECATED;
	///<summary>LinearLimitStiffness_DEPRECATED</summary>
	public float LinearLimitStiffness_DEPRECATED;
	///<summary>LinearLimitDamping_DEPRECATED</summary>
	public float LinearLimitDamping_DEPRECATED;
	///<summary>bLinearBreakable_DEPRECATED</summary>
	public bool bLinearBreakable_DEPRECATED;
	///<summary>LinearBreakThreshold_DEPRECATED</summary>
	public float LinearBreakThreshold_DEPRECATED;
	///<summary>AngularSwing1Motion_DEPRECATED</summary>
	public EAngularConstraintMotion AngularSwing1Motion_DEPRECATED;
	///<summary>AngularSwing2Motion_DEPRECATED</summary>
	public EAngularConstraintMotion AngularSwing2Motion_DEPRECATED;
	///<summary>AngularTwistMotion_DEPRECATED</summary>
	public EAngularConstraintMotion AngularTwistMotion_DEPRECATED;
	///<summary>bSwingLimitSoft_DEPRECATED</summary>
	public bool bSwingLimitSoft_DEPRECATED;
	///<summary>bTwistLimitSoft_DEPRECATED</summary>
	public bool bTwistLimitSoft_DEPRECATED;
	///<summary>Swing1LimitAngle_DEPRECATED</summary>
	public float Swing1LimitAngle_DEPRECATED;
	///<summary>Swing2LimitAngle_DEPRECATED</summary>
	public float Swing2LimitAngle_DEPRECATED;
	///<summary>TwistLimitAngle_DEPRECATED</summary>
	public float TwistLimitAngle_DEPRECATED;
	///<summary>SwingLimitStiffness_DEPRECATED</summary>
	public float SwingLimitStiffness_DEPRECATED;
	///<summary>SwingLimitDamping_DEPRECATED</summary>
	public float SwingLimitDamping_DEPRECATED;
	///<summary>TwistLimitStiffness_DEPRECATED</summary>
	public float TwistLimitStiffness_DEPRECATED;
	///<summary>TwistLimitDamping_DEPRECATED</summary>
	public float TwistLimitDamping_DEPRECATED;
	///<summary>bAngularBreakable_DEPRECATED</summary>
	public bool bAngularBreakable_DEPRECATED;
	///<summary>AngularBreakThreshold_DEPRECATED</summary>
	public float AngularBreakThreshold_DEPRECATED;
}
