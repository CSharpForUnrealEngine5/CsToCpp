#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/ConstraintInstanceBlueprintLibrary.h")]
public partial class UConstraintInstanceBlueprintLibrary : UBlueprintFunctionLibrary {
// ConstraintInstanceBlueprintLibrary
	public static void GetAttachedBodyNames(FConstraintInstanceAccessor Accessor,string ParentBody,string ChildBody) {}
	public static void SetDisableCollision(FConstraintInstanceAccessor Accessor,bool bDisableCollision) {}
	public static bool GetDisableCollsion(FConstraintInstanceAccessor Accessor) { return default; }
	public static void SetProjectionParams(FConstraintInstanceAccessor Accessor,bool bEnableProjection,float ProjectionLinearAlpha,float ProjectionAngularAlpha) {}
	public static void GetProjectionParams(FConstraintInstanceAccessor Accessor,bool bEnableProjection,float ProjectionLinearAlpha,float ProjectionAngularAlpha) {}
	public static void SetParentDominates(FConstraintInstanceAccessor Accessor,bool bParentDominates) {}
	public static bool GetParentDominates(FConstraintInstanceAccessor Accessor) { return default; }
	public static void SetMassConditioningEnabled(FConstraintInstanceAccessor Accessor,bool bEnableMassConditioning) {}
	public static bool GetMassConditioningEnabled(FConstraintInstanceAccessor Accessor) { return default; }
	public static void SetLinearLimits(FConstraintInstanceAccessor Accessor,ELinearConstraintMotion XMotion,ELinearConstraintMotion YMotion,ELinearConstraintMotion ZMotion,float Limit) {}
	public static void GetLinearLimits(FConstraintInstanceAccessor Accessor,ELinearConstraintMotion XMotion,ELinearConstraintMotion YMotion,ELinearConstraintMotion ZMotion,float Limit) {}
	public static void SetLinearSoftLimitParams(FConstraintInstanceAccessor Accessor,bool bSoftLinearLimit,float LinearLimitStiffness,float LinearLimitDamping,float LinearLimitRestitution,float LinearLimitContactDistance) {}
	public static void GetLinearSoftLimitParams(FConstraintInstanceAccessor Accessor,bool bSoftLinearLimit,float LinearLimitStiffness,float LinearLimitDamping,float LinearLimitRestitution,float LinearLimitContactDistance) {}
	public static void SetLinearBreakable(FConstraintInstanceAccessor Accessor,bool bLinearBreakable,float LinearBreakThreshold) {}
	public static void GetLinearBreakable(FConstraintInstanceAccessor Accessor,bool bLinearBreakable,float LinearBreakThreshold) {}
	public static void SetLinearPlasticity(FConstraintInstanceAccessor Accessor,bool bLinearPlasticity,float LinearPlasticityThreshold,EConstraintPlasticityType PlasticityType) {}
	public static void GetLinearPlasticity(FConstraintInstanceAccessor Accessor,bool bLinearPlasticity,float LinearPlasticityThreshold,EConstraintPlasticityType PlasticityType) {}
	public static void GetContactTransferScale(FConstraintInstanceAccessor Accessor,float ContactTransferScale) {}
	public static void SetContactTransferScale(FConstraintInstanceAccessor Accessor,float ContactTransferScale) {}
	public static void SetAngularLimits(FConstraintInstanceAccessor Accessor,EAngularConstraintMotion Swing1MotionType,float Swing1LimitAngle,EAngularConstraintMotion Swing2MotionType,float Swing2LimitAngle,EAngularConstraintMotion TwistMotionType,float TwistLimitAngle) {}
	public static void GetAngularLimits(FConstraintInstanceAccessor Accessor,EAngularConstraintMotion Swing1MotionType,float Swing1LimitAngle,EAngularConstraintMotion Swing2MotionType,float Swing2LimitAngle,EAngularConstraintMotion TwistMotionType,float TwistLimitAngle) {}
	public static void SetAngularSoftSwingLimitParams(FConstraintInstanceAccessor Accessor,bool bSoftSwingLimit,float SwingLimitStiffness,float SwingLimitDamping,float SwingLimitRestitution,float SwingLimitContactDistance) {}
	public static void GetAngularSoftSwingLimitParams(FConstraintInstanceAccessor Accessor,bool bSoftSwingLimit,float SwingLimitStiffness,float SwingLimitDamping,float SwingLimitRestitution,float SwingLimitContactDistance) {}
	public static void SetAngularSoftTwistLimitParams(FConstraintInstanceAccessor Accessor,bool bSoftTwistLimit,float TwistLimitStiffness,float TwistLimitDamping,float TwistLimitRestitution,float TwistLimitContactDistance) {}
	public static void GetAngularSoftTwistLimitParams(FConstraintInstanceAccessor Accessor,bool bSoftTwistLimit,float TwistLimitStiffness,float TwistLimitDamping,float TwistLimitRestitution,float TwistLimitContactDistance) {}
	public static void SetAngularBreakable(FConstraintInstanceAccessor Accessor,bool bAngularBreakable,float AngularBreakThreshold) {}
	public static void GetAngularBreakable(FConstraintInstanceAccessor Accessor,bool bAngularBreakable,float AngularBreakThreshold) {}
	public static void SetAngularPlasticity(FConstraintInstanceAccessor Accessor,bool bAngularPlasticity,float AngularPlasticityThreshold) {}
	public static void GetAngularPlasticity(FConstraintInstanceAccessor Accessor,bool bAngularPlasticity,float AngularPlasticityThreshold) {}
	public static void SetLinearPositionDrive(FConstraintInstanceAccessor Accessor,bool bEnableDriveX,bool bEnableDriveY,bool bEnableDriveZ) {}
	public static void GetLinearPositionDrive(FConstraintInstanceAccessor Accessor,bool bOutEnableDriveX,bool bOutEnableDriveY,bool bOutEnableDriveZ) {}
	public static void SetLinearVelocityDrive(FConstraintInstanceAccessor Accessor,bool bEnableDriveX,bool bEnableDriveY,bool bEnableDriveZ) {}
	public static void GetLinearVelocityDrive(FConstraintInstanceAccessor Accessor,bool bOutEnableDriveX,bool bOutEnableDriveY,bool bOutEnableDriveZ) {}
	public static void SetLinearPositionTarget(FConstraintInstanceAccessor Accessor,FVector InPosTarget) {}
	public static void GetLinearPositionTarget(FConstraintInstanceAccessor Accessor,FVector OutPosTarget) {}
	public static void SetLinearVelocityTarget(FConstraintInstanceAccessor Accessor,FVector InVelTarget) {}
	public static void GetLinearVelocityTarget(FConstraintInstanceAccessor Accessor,FVector OutVelTarget) {}
	public static void SetLinearDriveParams(FConstraintInstanceAccessor Accessor,float PositionStrength,float VelocityStrength,float InForceLimit) {}
	public static void GetLinearDriveParams(FConstraintInstanceAccessor Accessor,float OutPositionStrength,float OutVelocityStrength,float OutForceLimit) {}
	public static void SetOrientationDriveTwistAndSwing(FConstraintInstanceAccessor Accessor,bool bEnableTwistDrive,bool bEnableSwingDrive) {}
	public static void GetOrientationDriveTwistAndSwing(FConstraintInstanceAccessor Accessor,bool bOutEnableTwistDrive,bool bOutEnableSwingDrive) {}
	public static void SetOrientationDriveSLERP(FConstraintInstanceAccessor Accessor,bool bEnableSLERP) {}
	public static void GetOrientationDriveSLERP(FConstraintInstanceAccessor Accessor,bool bOutEnableSLERP) {}
	public static void SetAngularVelocityDriveTwistAndSwing(FConstraintInstanceAccessor Accessor,bool bEnableTwistDrive,bool bEnableSwingDrive) {}
	public static void GetAngularVelocityDriveTwistAndSwing(FConstraintInstanceAccessor Accessor,bool bOutEnableTwistDrive,bool bOutEnableSwingDrive) {}
	public static void SetAngularVelocityDriveSLERP(FConstraintInstanceAccessor Accessor,bool bEnableSLERP) {}
	public static void GetAngularVelocityDriveSLERP(FConstraintInstanceAccessor Accessor,bool bOutEnableSLERP) {}
	public static void SetAngularDriveMode(FConstraintInstanceAccessor Accessor,EAngularDriveMode DriveMode) {}
	public static void GetAngularDriveMode(FConstraintInstanceAccessor Accessor,EAngularDriveMode OutDriveMode) {}
	public static void SetAngularOrientationTarget(FConstraintInstanceAccessor Accessor,FRotator InPosTarget) {}
	public static void GetAngularOrientationTarget(FConstraintInstanceAccessor Accessor,FRotator OutPosTarget) {}
	public static void SetAngularVelocityTarget(FConstraintInstanceAccessor Accessor,FVector InVelTarget) {}
	public static void GetAngularVelocityTarget(FConstraintInstanceAccessor Accessor,FVector OutVelTarget) {}
	public static void SetAngularDriveParams(FConstraintInstanceAccessor Accessor,float PositionStrength,float VelocityStrength,float InForceLimit) {}
	public static void GetAngularDriveParams(FConstraintInstanceAccessor Accessor,float OutPositionStrength,float OutVelocityStrength,float OutForceLimit) {}
	public static void CopyParams(FConstraintInstanceAccessor Accessor,FConstraintInstanceAccessor SourceAccessor,bool bKeepPosition/*=true*/,bool bKeepRotation/*=true*/) {}
}
