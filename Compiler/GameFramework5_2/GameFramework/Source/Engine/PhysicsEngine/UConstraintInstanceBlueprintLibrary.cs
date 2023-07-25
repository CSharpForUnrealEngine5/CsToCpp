#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/ConstraintInstanceBlueprintLibrary.h")]
public partial class UConstraintInstanceBlueprintLibrary : UBlueprintFunctionLibrary {
// ConstraintInstanceBlueprintLibrary
	public void GetAttachedBodyNames(FConstraintInstanceAccessor Accessor,string ParentBody,string ChildBody) {}
	public void SetDisableCollision(FConstraintInstanceAccessor Accessor,bool bDisableCollision) {}
	public bool GetDisableCollsion(FConstraintInstanceAccessor Accessor) { return default; }
	public void SetProjectionParams(FConstraintInstanceAccessor Accessor,bool bEnableProjection,float ProjectionLinearAlpha,float ProjectionAngularAlpha) {}
	public void GetProjectionParams(FConstraintInstanceAccessor Accessor,bool bEnableProjection,float ProjectionLinearAlpha,float ProjectionAngularAlpha) {}
	public void SetParentDominates(FConstraintInstanceAccessor Accessor,bool bParentDominates) {}
	public bool GetParentDominates(FConstraintInstanceAccessor Accessor) { return default; }
	public void SetMassConditioningEnabled(FConstraintInstanceAccessor Accessor,bool bEnableMassConditioning) {}
	public bool GetMassConditioningEnabled(FConstraintInstanceAccessor Accessor) { return default; }
	public void SetLinearLimits(FConstraintInstanceAccessor Accessor,byte XMotion,byte YMotion,byte ZMotion,float Limit) {}
	public void GetLinearLimits(FConstraintInstanceAccessor Accessor,byte XMotion,byte YMotion,byte ZMotion,float Limit) {}
	public void SetLinearSoftLimitParams(FConstraintInstanceAccessor Accessor,bool bSoftLinearLimit,float LinearLimitStiffness,float LinearLimitDamping,float LinearLimitRestitution,float LinearLimitContactDistance) {}
	public void GetLinearSoftLimitParams(FConstraintInstanceAccessor Accessor,bool bSoftLinearLimit,float LinearLimitStiffness,float LinearLimitDamping,float LinearLimitRestitution,float LinearLimitContactDistance) {}
	public void SetLinearBreakable(FConstraintInstanceAccessor Accessor,bool bLinearBreakable,float LinearBreakThreshold) {}
	public void GetLinearBreakable(FConstraintInstanceAccessor Accessor,bool bLinearBreakable,float LinearBreakThreshold) {}
	public void SetLinearPlasticity(FConstraintInstanceAccessor Accessor,bool bLinearPlasticity,float LinearPlasticityThreshold,byte PlasticityType) {}
	public void GetLinearPlasticity(FConstraintInstanceAccessor Accessor,bool bLinearPlasticity,float LinearPlasticityThreshold,byte PlasticityType) {}
	public void GetContactTransferScale(FConstraintInstanceAccessor Accessor,float ContactTransferScale) {}
	public void SetContactTransferScale(FConstraintInstanceAccessor Accessor,float ContactTransferScale) {}
	public void SetAngularLimits(FConstraintInstanceAccessor Accessor,byte Swing1MotionType,float Swing1LimitAngle,byte Swing2MotionType,float Swing2LimitAngle,byte TwistMotionType,float TwistLimitAngle) {}
	public void GetAngularLimits(FConstraintInstanceAccessor Accessor,byte Swing1MotionType,float Swing1LimitAngle,byte Swing2MotionType,float Swing2LimitAngle,byte TwistMotionType,float TwistLimitAngle) {}
	public void SetAngularSoftSwingLimitParams(FConstraintInstanceAccessor Accessor,bool bSoftSwingLimit,float SwingLimitStiffness,float SwingLimitDamping,float SwingLimitRestitution,float SwingLimitContactDistance) {}
	public void GetAngularSoftSwingLimitParams(FConstraintInstanceAccessor Accessor,bool bSoftSwingLimit,float SwingLimitStiffness,float SwingLimitDamping,float SwingLimitRestitution,float SwingLimitContactDistance) {}
	public void SetAngularSoftTwistLimitParams(FConstraintInstanceAccessor Accessor,bool bSoftTwistLimit,float TwistLimitStiffness,float TwistLimitDamping,float TwistLimitRestitution,float TwistLimitContactDistance) {}
	public void GetAngularSoftTwistLimitParams(FConstraintInstanceAccessor Accessor,bool bSoftTwistLimit,float TwistLimitStiffness,float TwistLimitDamping,float TwistLimitRestitution,float TwistLimitContactDistance) {}
	public void SetAngularBreakable(FConstraintInstanceAccessor Accessor,bool bAngularBreakable,float AngularBreakThreshold) {}
	public void GetAngularBreakable(FConstraintInstanceAccessor Accessor,bool bAngularBreakable,float AngularBreakThreshold) {}
	public void SetAngularPlasticity(FConstraintInstanceAccessor Accessor,bool bAngularPlasticity,float AngularPlasticityThreshold) {}
	public void GetAngularPlasticity(FConstraintInstanceAccessor Accessor,bool bAngularPlasticity,float AngularPlasticityThreshold) {}
	public void SetLinearPositionDrive(FConstraintInstanceAccessor Accessor,bool bEnableDriveX,bool bEnableDriveY,bool bEnableDriveZ) {}
	public void GetLinearPositionDrive(FConstraintInstanceAccessor Accessor,bool bOutEnableDriveX,bool bOutEnableDriveY,bool bOutEnableDriveZ) {}
	public void SetLinearVelocityDrive(FConstraintInstanceAccessor Accessor,bool bEnableDriveX,bool bEnableDriveY,bool bEnableDriveZ) {}
	public void GetLinearVelocityDrive(FConstraintInstanceAccessor Accessor,bool bOutEnableDriveX,bool bOutEnableDriveY,bool bOutEnableDriveZ) {}
	public void SetLinearPositionTarget(FConstraintInstanceAccessor Accessor,FVector InPosTarget) {}
	public void GetLinearPositionTarget(FConstraintInstanceAccessor Accessor,FVector OutPosTarget) {}
	public void SetLinearVelocityTarget(FConstraintInstanceAccessor Accessor,FVector InVelTarget) {}
	public void GetLinearVelocityTarget(FConstraintInstanceAccessor Accessor,FVector OutVelTarget) {}
	public void SetLinearDriveParams(FConstraintInstanceAccessor Accessor,float PositionStrength,float VelocityStrength,float InForceLimit) {}
	public void GetLinearDriveParams(FConstraintInstanceAccessor Accessor,float OutPositionStrength,float OutVelocityStrength,float OutForceLimit) {}
	public void SetOrientationDriveTwistAndSwing(FConstraintInstanceAccessor Accessor,bool bEnableTwistDrive,bool bEnableSwingDrive) {}
	public void GetOrientationDriveTwistAndSwing(FConstraintInstanceAccessor Accessor,bool bOutEnableTwistDrive,bool bOutEnableSwingDrive) {}
	public void SetOrientationDriveSLERP(FConstraintInstanceAccessor Accessor,bool bEnableSLERP) {}
	public void GetOrientationDriveSLERP(FConstraintInstanceAccessor Accessor,bool bOutEnableSLERP) {}
	public void SetAngularVelocityDriveTwistAndSwing(FConstraintInstanceAccessor Accessor,bool bEnableTwistDrive,bool bEnableSwingDrive) {}
	public void GetAngularVelocityDriveTwistAndSwing(FConstraintInstanceAccessor Accessor,bool bOutEnableTwistDrive,bool bOutEnableSwingDrive) {}
	public void SetAngularVelocityDriveSLERP(FConstraintInstanceAccessor Accessor,bool bEnableSLERP) {}
	public void GetAngularVelocityDriveSLERP(FConstraintInstanceAccessor Accessor,bool bOutEnableSLERP) {}
	public void SetAngularDriveMode(FConstraintInstanceAccessor Accessor,EAngularDriveMode DriveMode) {}
	public void GetAngularDriveMode(FConstraintInstanceAccessor Accessor,byte OutDriveMode) {}
	public void SetAngularOrientationTarget(FConstraintInstanceAccessor Accessor,FRotator InPosTarget) {}
	public void GetAngularOrientationTarget(FConstraintInstanceAccessor Accessor,FRotator OutPosTarget) {}
	public void SetAngularVelocityTarget(FConstraintInstanceAccessor Accessor,FVector InVelTarget) {}
	public void GetAngularVelocityTarget(FConstraintInstanceAccessor Accessor,FVector OutVelTarget) {}
	public void SetAngularDriveParams(FConstraintInstanceAccessor Accessor,float PositionStrength,float VelocityStrength,float InForceLimit) {}
	public void GetAngularDriveParams(FConstraintInstanceAccessor Accessor,float OutPositionStrength,float OutVelocityStrength,float OutForceLimit) {}
	public void CopyParams(FConstraintInstanceAccessor Accessor,FConstraintInstanceAccessor SourceAccessor,bool bKeepPosition/*=true*/,bool bKeepRotation/*=true*/) {}
}
