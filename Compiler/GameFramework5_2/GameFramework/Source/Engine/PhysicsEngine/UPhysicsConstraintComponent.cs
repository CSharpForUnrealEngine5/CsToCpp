#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicsConstraintComponent.h")]
///<summary>This is effectively a joint that allows you to connect 2 rigid bodies together. You can create different types of joints using the various parameters of this component.</summary>
public partial class UPhysicsConstraintComponent : USceneComponent {
// PhysicsConstraintComponent
	public AActor ConstraintActor1;
	public FConstrainComponentPropName ComponentName1;
	public AActor ConstraintActor2;
	public FConstrainComponentPropName ComponentName2;
	public UPhysicsConstraintTemplate ConstraintSetup_DEPRECATED;
	public FConstraintBrokenSignature OnConstraintBroken;
	public FPlasticDeformationEventSignature OnPlasticDeformation;
	public FConstraintInstance ConstraintInstance;
	public  void SetConstrainedComponents(UPrimitiveComponent Component1,string BoneName1,UPrimitiveComponent Component2,string BoneName2) {}
	public  void GetConstrainedComponents(UPrimitiveComponent OutComponent1,string OutBoneName1,UPrimitiveComponent OutComponent2,string OutBoneName2) {}
	public  void BreakConstraint() {}
	public  void SetLinearPositionDrive(bool bEnableDriveX,bool bEnableDriveY,bool bEnableDriveZ) {}
	public  void SetLinearVelocityDrive(bool bEnableDriveX,bool bEnableDriveY,bool bEnableDriveZ) {}
	public  void SetAngularOrientationDrive(bool bEnableSwingDrive,bool bEnableTwistDrive) {}
	public  void SetOrientationDriveTwistAndSwing(bool bEnableTwistDrive,bool bEnableSwingDrive) {}
	public  void SetOrientationDriveSLERP(bool bEnableSLERP) {}
	public  void SetAngularVelocityDrive(bool bEnableSwingDrive,bool bEnableTwistDrive) {}
	public  void SetAngularVelocityDriveTwistAndSwing(bool bEnableTwistDrive,bool bEnableSwingDrive) {}
	public  void SetAngularVelocityDriveSLERP(bool bEnableSLERP) {}
	public  void SetAngularDriveMode(EAngularDriveMode DriveMode) {}
	public  void SetLinearPositionTarget(FVector InPosTarget) {}
	public  void SetLinearVelocityTarget(FVector InVelTarget) {}
	public  void SetLinearDriveParams(float PositionStrength,float VelocityStrength,float InForceLimit) {}
	public  void SetAngularOrientationTarget(FRotator InPosTarget) {}
	public  void SetAngularVelocityTarget(FVector InVelTarget) {}
	public  void SetAngularDriveParams(float PositionStrength,float VelocityStrength,float InForceLimit) {}
	public  void SetLinearXLimit(ELinearConstraintMotion ConstraintType,float LimitSize) {}
	public  void SetLinearYLimit(ELinearConstraintMotion ConstraintType,float LimitSize) {}
	public  void SetLinearZLimit(ELinearConstraintMotion ConstraintType,float LimitSize) {}
	public  void SetAngularSwing1Limit(EAngularConstraintMotion MotionType,float Swing1LimitAngle) {}
	public  void SetAngularSwing2Limit(EAngularConstraintMotion MotionType,float Swing2LimitAngle) {}
	public  void SetAngularTwistLimit(EAngularConstraintMotion ConstraintType,float TwistLimitAngle) {}
	public  void SetLinearBreakable(bool bLinearBreakable,float LinearBreakThreshold) {}
	public  void SetLinearPlasticity(bool bLinearPlasticity,float LinearPlasticityThreshold,EConstraintPlasticityType PlasticityType) {}
	public  void SetAngularBreakable(bool bAngularBreakable,float AngularBreakThreshold) {}
	public  void SetAngularPlasticity(bool bAngularPlasticity,float AngularPlasticityThreshold) {}
	public  void SetContactTransferScale(float ContactTransferScale) {}
	public  float GetCurrentTwist() { return default; }
	public  float GetCurrentSwing1() { return default; }
	public  float GetCurrentSwing2() { return default; }
	public  void SetConstraintReferenceFrame(EConstraintFrame Frame,FTransform RefFrame) {}
	public  void SetConstraintReferencePosition(EConstraintFrame Frame,FVector RefPosition) {}
	public  void SetConstraintReferenceOrientation(EConstraintFrame Frame,FVector PriAxis,FVector SecAxis) {}
	public  void SetDisableCollision(bool bDisableCollision) {}
	public  void GetConstraintForce(FVector OutLinearForce,FVector OutAngularForce) {}
	public  bool IsBroken() { return default; }
	public  FConstraintInstanceAccessor GetConstraint() { return default; }
}
