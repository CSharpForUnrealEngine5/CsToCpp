#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/ConstraintInstanceBlueprintLibrary.h")]
public partial class UConstraintInstanceBlueprintLibrary : UBlueprintFunctionLibrary {
	///<summary>Gets Attached body names</summary>
	public static void GetAttachedBodyNames(FConstraintInstanceAccessor Accessor,string ParentBody,string ChildBody) {}
	///<summary>Sets whether bodies attched to the constraint can collide or not</summary>
	public static void SetDisableCollision(FConstraintInstanceAccessor Accessor,bool bDisableCollision) {}
	///<summary>Gets whether bodies attched to the constraint can collide or not</summary>
	public static bool GetDisableCollsion(FConstraintInstanceAccessor Accessor) { return default; }
	///<summary>Sets projection parameters of the constraint</summary>
	public static void SetProjectionParams(FConstraintInstanceAccessor Accessor,bool bEnableProjection,float ProjectionLinearAlpha,float ProjectionAngularAlpha) {}
	///<summary>Gets projection parameters of the constraint</summary>
	public static void GetProjectionParams(FConstraintInstanceAccessor Accessor,bool bEnableProjection,float ProjectionLinearAlpha,float ProjectionAngularAlpha) {}
	///<summary>Sets whether the parent body is not affected by it&#39;s child motion</summary>
	public static void SetParentDominates(FConstraintInstanceAccessor Accessor,bool bParentDominates) {}
	///<summary>Gets whether the parent body is not affected by it&#39;s child motion</summary>
	public static bool GetParentDominates(FConstraintInstanceAccessor Accessor) { return default; }
	///<summary>@brief Enable or disable mass conditioning for the constraint.</summary>
	public static void SetMassConditioningEnabled(FConstraintInstanceAccessor Accessor,bool bEnableMassConditioning) {}
	///<summary>@brief Gets whether mass conditioning is enabled for the constraint.</summary>
	public static bool GetMassConditioningEnabled(FConstraintInstanceAccessor Accessor) { return default; }
	///<summary>Sets Constraint Linear Motion Ranges</summary>
	public static void SetLinearLimits(FConstraintInstanceAccessor Accessor,ELinearConstraintMotion XMotion,ELinearConstraintMotion YMotion,ELinearConstraintMotion ZMotion,float Limit) {}
	///<summary>Gets Constraint Linear Motion Ranges</summary>
	public static void GetLinearLimits(FConstraintInstanceAccessor Accessor,ELinearConstraintMotion XMotion,ELinearConstraintMotion YMotion,ELinearConstraintMotion ZMotion,float Limit) {}
	///<summary>Sets Constraint Linear Soft Limit parameters</summary>
	public static void SetLinearSoftLimitParams(FConstraintInstanceAccessor Accessor,bool bSoftLinearLimit,float LinearLimitStiffness,float LinearLimitDamping,float LinearLimitRestitution,float LinearLimitContactDistance) {}
	///<summary>Gets Constraint Linear Soft Limit parameters</summary>
	public static void GetLinearSoftLimitParams(FConstraintInstanceAccessor Accessor,bool bSoftLinearLimit,float LinearLimitStiffness,float LinearLimitDamping,float LinearLimitRestitution,float LinearLimitContactDistance) {}
	///<summary>Sets the Linear Breakable properties</summary>
	public static void SetLinearBreakable(FConstraintInstanceAccessor Accessor,bool bLinearBreakable,float LinearBreakThreshold) {}
	///<summary>Gets Constraint Linear Breakable properties</summary>
	public static void GetLinearBreakable(FConstraintInstanceAccessor Accessor,bool bLinearBreakable,float LinearBreakThreshold) {}
	///<summary>Sets Constraint Linear Plasticity properties</summary>
	public static void SetLinearPlasticity(FConstraintInstanceAccessor Accessor,bool bLinearPlasticity,float LinearPlasticityThreshold,EConstraintPlasticityType PlasticityType) {}
	///<summary>Gets Constraint Linear Plasticity properties</summary>
	public static void GetLinearPlasticity(FConstraintInstanceAccessor Accessor,bool bLinearPlasticity,float LinearPlasticityThreshold,EConstraintPlasticityType PlasticityType) {}
	///<summary>Gets Constraint Contact Transfer Scale properties</summary>
	public static void GetContactTransferScale(FConstraintInstanceAccessor Accessor,float ContactTransferScale) {}
	///<summary>Set Contact Transfer Scale</summary>
	public static void SetContactTransferScale(FConstraintInstanceAccessor Accessor,float ContactTransferScale) {}
	///<summary>Sets COnstraint Angular Motion Ranges</summary>
	public static void SetAngularLimits(FConstraintInstanceAccessor Accessor,EAngularConstraintMotion Swing1MotionType,float Swing1LimitAngle,EAngularConstraintMotion Swing2MotionType,float Swing2LimitAngle,EAngularConstraintMotion TwistMotionType,float TwistLimitAngle) {}
	///<summary>Gets Constraint Angular Motion Ranges</summary>
	public static void GetAngularLimits(FConstraintInstanceAccessor Accessor,EAngularConstraintMotion Swing1MotionType,float Swing1LimitAngle,EAngularConstraintMotion Swing2MotionType,float Swing2LimitAngle,EAngularConstraintMotion TwistMotionType,float TwistLimitAngle) {}
	///<summary>Sets Constraint Angular Soft Swing Limit parameters</summary>
	public static void SetAngularSoftSwingLimitParams(FConstraintInstanceAccessor Accessor,bool bSoftSwingLimit,float SwingLimitStiffness,float SwingLimitDamping,float SwingLimitRestitution,float SwingLimitContactDistance) {}
	///<summary>Gets Constraint Angular Soft Swing Limit parameters</summary>
	public static void GetAngularSoftSwingLimitParams(FConstraintInstanceAccessor Accessor,bool bSoftSwingLimit,float SwingLimitStiffness,float SwingLimitDamping,float SwingLimitRestitution,float SwingLimitContactDistance) {}
	///<summary>Sets Constraint Angular Soft Twist Limit parameters</summary>
	public static void SetAngularSoftTwistLimitParams(FConstraintInstanceAccessor Accessor,bool bSoftTwistLimit,float TwistLimitStiffness,float TwistLimitDamping,float TwistLimitRestitution,float TwistLimitContactDistance) {}
	///<summary>Gets Constraint Angular Soft Twist Limit parameters</summary>
	public static void GetAngularSoftTwistLimitParams(FConstraintInstanceAccessor Accessor,bool bSoftTwistLimit,float TwistLimitStiffness,float TwistLimitDamping,float TwistLimitRestitution,float TwistLimitContactDistance) {}
	///<summary>Sets Constraint Angular Breakable properties</summary>
	public static void SetAngularBreakable(FConstraintInstanceAccessor Accessor,bool bAngularBreakable,float AngularBreakThreshold) {}
	///<summary>Gets Constraint Angular Breakable properties</summary>
	public static void GetAngularBreakable(FConstraintInstanceAccessor Accessor,bool bAngularBreakable,float AngularBreakThreshold) {}
	///<summary>Sets Constraint Angular Plasticity properties</summary>
	public static void SetAngularPlasticity(FConstraintInstanceAccessor Accessor,bool bAngularPlasticity,float AngularPlasticityThreshold) {}
	///<summary>Sets Constraint Angular Plasticity properties</summary>
	public static void GetAngularPlasticity(FConstraintInstanceAccessor Accessor,bool bAngularPlasticity,float AngularPlasticityThreshold) {}
	///<summary>Enables/Disables linear position drive</summary>
	public static void SetLinearPositionDrive(FConstraintInstanceAccessor Accessor,bool bEnableDriveX,bool bEnableDriveY,bool bEnableDriveZ) {}
	///<summary>Gets whether linear position drive is enabled or not</summary>
	public static void GetLinearPositionDrive(FConstraintInstanceAccessor Accessor,bool bOutEnableDriveX,bool bOutEnableDriveY,bool bOutEnableDriveZ) {}
	///<summary>Enables/Disables linear velocity drive</summary>
	public static void SetLinearVelocityDrive(FConstraintInstanceAccessor Accessor,bool bEnableDriveX,bool bEnableDriveY,bool bEnableDriveZ) {}
	///<summary>Gets whether linear velocity drive is enabled or not</summary>
	public static void GetLinearVelocityDrive(FConstraintInstanceAccessor Accessor,bool bOutEnableDriveX,bool bOutEnableDriveY,bool bOutEnableDriveZ) {}
	///<summary>Sets the target position for the linear drive.</summary>
	public static void SetLinearPositionTarget(FConstraintInstanceAccessor Accessor,FVector InPosTarget) {}
	///<summary>Gets the target position for the linear drive.</summary>
	public static void GetLinearPositionTarget(FConstraintInstanceAccessor Accessor,FVector OutPosTarget) {}
	///<summary>Sets the target velocity for the linear drive.</summary>
	public static void SetLinearVelocityTarget(FConstraintInstanceAccessor Accessor,FVector InVelTarget) {}
	///<summary>Gets the target velocity for the linear drive.</summary>
	public static void GetLinearVelocityTarget(FConstraintInstanceAccessor Accessor,FVector OutVelTarget) {}
	///<summary>Sets the drive params for the linear drive.</summary>
	public static void SetLinearDriveParams(FConstraintInstanceAccessor Accessor,float PositionStrength,float VelocityStrength,float InForceLimit) {}
	///<summary>Gets the drive params for the linear drive.</summary>
	public static void GetLinearDriveParams(FConstraintInstanceAccessor Accessor,float OutPositionStrength,float OutVelocityStrength,float OutForceLimit) {}
	///<summary>Enables/Disables angular orientation drive. Only relevant if the AngularDriveMode is set to Twist and Swing</summary>
	public static void SetOrientationDriveTwistAndSwing(FConstraintInstanceAccessor Accessor,bool bEnableTwistDrive,bool bEnableSwingDrive) {}
	///<summary>Gets whether angular orientation drive are enabled. Only relevant if the AngularDriveMode is set to Twist and Swing</summary>
	public static void GetOrientationDriveTwistAndSwing(FConstraintInstanceAccessor Accessor,bool bOutEnableTwistDrive,bool bOutEnableSwingDrive) {}
	///<summary>Enables/Disables the angular orientation slerp drive. Only relevant if the AngularDriveMode is set to SLERP</summary>
	public static void SetOrientationDriveSLERP(FConstraintInstanceAccessor Accessor,bool bEnableSLERP) {}
	///<summary>Gets whether the angular orientation slerp drive is enabled or not. Only relevant if the AngularDriveMode is set to SLERP</summary>
	public static void GetOrientationDriveSLERP(FConstraintInstanceAccessor Accessor,bool bOutEnableSLERP) {}
	///<summary>Enables/Disables angular velocity twist and swing drive. Only relevant if the AngularDriveMode is set to Twist and Swing</summary>
	public static void SetAngularVelocityDriveTwistAndSwing(FConstraintInstanceAccessor Accessor,bool bEnableTwistDrive,bool bEnableSwingDrive) {}
	///<summary>Gets whether angular velocity twist and swing drive is enabled or not. Only relevant if the AngularDriveMode is set to Twist and Swing</summary>
	public static void GetAngularVelocityDriveTwistAndSwing(FConstraintInstanceAccessor Accessor,bool bOutEnableTwistDrive,bool bOutEnableSwingDrive) {}
	///<summary>Enables/Disables the angular velocity slerp drive. Only relevant if the AngularDriveMode is set to SLERP</summary>
	public static void SetAngularVelocityDriveSLERP(FConstraintInstanceAccessor Accessor,bool bEnableSLERP) {}
	///<summary>Gets whether the angular velocity slerp drive is enabled or not. Only relevant if the AngularDriveMode is set to SLERP</summary>
	public static void GetAngularVelocityDriveSLERP(FConstraintInstanceAccessor Accessor,bool bOutEnableSLERP) {}
	///<summary>Switches the angular drive mode between SLERP and Twist And Swing</summary>
	public static void SetAngularDriveMode(FConstraintInstanceAccessor Accessor,EAngularDriveMode DriveMode) {}
	///<summary>Gets the angular drive mode ( SLERP or Twist And Swing)</summary>
	public static void GetAngularDriveMode(FConstraintInstanceAccessor Accessor,EAngularDriveMode OutDriveMode) {}
	///<summary>Sets the target orientation for the angular drive.</summary>
	public static void SetAngularOrientationTarget(FConstraintInstanceAccessor Accessor,FRotator InPosTarget) {}
	///<summary>Gets the target orientation for the angular drive.</summary>
	public static void GetAngularOrientationTarget(FConstraintInstanceAccessor Accessor,FRotator OutPosTarget) {}
	///<summary>Sets the target velocity for the angular drive.</summary>
	public static void SetAngularVelocityTarget(FConstraintInstanceAccessor Accessor,FVector InVelTarget) {}
	///<summary>Gets the target velocity for the angular drive.</summary>
	public static void GetAngularVelocityTarget(FConstraintInstanceAccessor Accessor,FVector OutVelTarget) {}
	///<summary>Sets the drive params for the angular drive.</summary>
	public static void SetAngularDriveParams(FConstraintInstanceAccessor Accessor,float PositionStrength,float VelocityStrength,float InForceLimit) {}
	///<summary>Gets the drive params for the angular drive.</summary>
	public static void GetAngularDriveParams(FConstraintInstanceAccessor Accessor,float OutPositionStrength,float OutVelocityStrength,float OutForceLimit) {}
	///<summary>Copies all properties from one constraint to another</summary>
	public static void CopyParams(FConstraintInstanceAccessor Accessor,FConstraintInstanceAccessor SourceAccessor,bool bKeepPosition/*=true*/,bool bKeepRotation/*=true*/) {}
}
