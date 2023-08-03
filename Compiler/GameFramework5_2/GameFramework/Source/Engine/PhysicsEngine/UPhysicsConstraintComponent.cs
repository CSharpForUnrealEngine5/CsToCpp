#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is effectively a joint that allows you to connect 2 rigid bodies together. You can create different types of joints using the various parameters of this component.</summary>
[CppInclude("PhysicsEngine/PhysicsConstraintComponent.h")]
public partial class UPhysicsConstraintComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Pointer to first Actor to constrain.</summary>
	public AActor ConstraintActor1;
	///<summary>Name of first component property to constrain. If Actor1 is NULL, will look within Owner.</summary>
	public FConstrainComponentPropName ComponentName1;
	///<summary>Pointer to second Actor to constrain.</summary>
	public AActor ConstraintActor2;
	///<summary>Name of second component property to constrain. If Actor2 is NULL, will look within Owner.</summary>
	public FConstrainComponentPropName ComponentName2;
	///<summary>ConstraintSetup_DEPRECATED</summary>
	public UPhysicsConstraintTemplate ConstraintSetup_DEPRECATED;
	///<summary>Notification when constraint is broken.</summary>
	public FConstraintBrokenSignature OnConstraintBroken;
	///<summary>Notification when constraint plasticity drive target changes.</summary>
	public FPlasticDeformationEventSignature OnPlasticDeformation;
	///<summary>All constraint settings</summary>
	public FConstraintInstance ConstraintInstance;
	///<summary>Directly specify component to connect. Will update frames based on current position.</summary>
	public  void SetConstrainedComponents(UPrimitiveComponent Component1,string BoneName1,UPrimitiveComponent Component2,string BoneName2) {}
	///<summary>Get connected components and potential related attachement bones</summary>
	public  void GetConstrainedComponents(UPrimitiveComponent OutComponent1,string OutBoneName1,UPrimitiveComponent OutComponent2,string OutBoneName2) {}
	///<summary>Break this constraint</summary>
	public  void BreakConstraint() {}
	///<summary>Enables/Disables linear position drive</summary>
	public  void SetLinearPositionDrive(bool bEnableDriveX,bool bEnableDriveY,bool bEnableDriveZ) {}
	///<summary>Enables/Disables linear position drive</summary>
	public  void SetLinearVelocityDrive(bool bEnableDriveX,bool bEnableDriveY,bool bEnableDriveZ) {}
	///<summary>Enables/Disables angular orientation drive. Only relevant if the AngularDriveMode is set to Twist and Swing</summary>
	public  void SetAngularOrientationDrive(bool bEnableSwingDrive,bool bEnableTwistDrive) {}
	///<summary>Enables/Disables angular orientation drive. Only relevant if the AngularDriveMode is set to Twist and Swing</summary>
	public  void SetOrientationDriveTwistAndSwing(bool bEnableTwistDrive,bool bEnableSwingDrive) {}
	///<summary>Enables/Disables the angular orientation slerp drive. Only relevant if the AngularDriveMode is set to SLERP</summary>
	public  void SetOrientationDriveSLERP(bool bEnableSLERP) {}
	///<summary>SetAngularVelocityDrive</summary>
	public  void SetAngularVelocityDrive(bool bEnableSwingDrive,bool bEnableTwistDrive) {}
	///<summary>Enables/Disables angular velocity twist and swing drive. Only relevant if the AngularDriveMode is set to Twist and Swing</summary>
	public  void SetAngularVelocityDriveTwistAndSwing(bool bEnableTwistDrive,bool bEnableSwingDrive) {}
	///<summary>Enables/Disables the angular velocity slerp drive. Only relevant if the AngularDriveMode is set to SLERP</summary>
	public  void SetAngularVelocityDriveSLERP(bool bEnableSLERP) {}
	///<summary>Switches the angular drive mode between SLERP and Twist And Swing</summary>
	public  void SetAngularDriveMode(EAngularDriveMode DriveMode) {}
	///<summary>Sets the target position for the linear drive.</summary>
	public  void SetLinearPositionTarget(FVector InPosTarget) {}
	///<summary>Sets the target velocity for the linear drive.</summary>
	public  void SetLinearVelocityTarget(FVector InVelTarget) {}
	///<summary>Sets the drive params for the linear drive.</summary>
	public  void SetLinearDriveParams(float PositionStrength,float VelocityStrength,float InForceLimit) {}
	///<summary>Sets the target orientation for the angular drive.</summary>
	public  void SetAngularOrientationTarget(FRotator InPosTarget) {}
	///<summary>Sets the target velocity for the angular drive.</summary>
	public  void SetAngularVelocityTarget(FVector InVelTarget) {}
	///<summary>Sets the drive params for the angular drive.</summary>
	public  void SetAngularDriveParams(float PositionStrength,float VelocityStrength,float InForceLimit) {}
	///<summary>Sets the LinearX Motion Type</summary>
	public  void SetLinearXLimit(ELinearConstraintMotion ConstraintType,float LimitSize) {}
	///<summary>Sets the LinearY Motion Type</summary>
	public  void SetLinearYLimit(ELinearConstraintMotion ConstraintType,float LimitSize) {}
	///<summary>Sets the LinearZ Motion Type</summary>
	public  void SetLinearZLimit(ELinearConstraintMotion ConstraintType,float LimitSize) {}
	///<summary>Sets the Angular Swing1 Motion Type</summary>
	public  void SetAngularSwing1Limit(EAngularConstraintMotion MotionType,float Swing1LimitAngle) {}
	///<summary>Sets the Angular Swing2 Motion Type</summary>
	public  void SetAngularSwing2Limit(EAngularConstraintMotion MotionType,float Swing2LimitAngle) {}
	///<summary>Sets the Angular Twist Motion Type</summary>
	public  void SetAngularTwistLimit(EAngularConstraintMotion ConstraintType,float TwistLimitAngle) {}
	///<summary>Sets the Linear Breakable properties</summary>
	public  void SetLinearBreakable(bool bLinearBreakable,float LinearBreakThreshold) {}
	///<summary>Sets the Linear Plasticity properties</summary>
	public  void SetLinearPlasticity(bool bLinearPlasticity,float LinearPlasticityThreshold,EConstraintPlasticityType PlasticityType) {}
	///<summary>Sets the Angular Breakable properties</summary>
	public  void SetAngularBreakable(bool bAngularBreakable,float AngularBreakThreshold) {}
	///<summary>Sets the Angular Plasticity properties</summary>
	public  void SetAngularPlasticity(bool bAngularPlasticity,float AngularPlasticityThreshold) {}
	///<summary>Sets the contact transfer scale properties</summary>
	public  void SetContactTransferScale(float ContactTransferScale) {}
	///<summary>Gets the current Angular Twist of the constraint</summary>
	public  float GetCurrentTwist() { return default; }
	///<summary>Gets the current Swing1 of the constraint</summary>
	public  float GetCurrentSwing1() { return default; }
	///<summary>Gets the current Swing2 of the constraint</summary>
	public  float GetCurrentSwing2() { return default; }
	///<summary>Pass in reference frame in. If the constraint is currently active, this will set its active local pose. Otherwise the change will take affect in InitConstraint.</summary>
	public  void SetConstraintReferenceFrame(EConstraintFrame Frame,FTransform RefFrame) {}
	///<summary>Pass in reference position in (maintains reference orientation). If the constraint is currently active, this will set its active local pose. Otherwise the change will take affect in InitConstraint.</summary>
	public  void SetConstraintReferencePosition(EConstraintFrame Frame,FVector RefPosition) {}
	///<summary>Pass in reference orientation in (maintains reference position). If the constraint is currently active, this will set its active local pose. Otherwise the change will take affect in InitConstraint.</summary>
	public  void SetConstraintReferenceOrientation(EConstraintFrame Frame,FVector PriAxis,FVector SecAxis) {}
	///<summary>If true, the collision between the two rigid bodies of the constraint will be disabled.</summary>
	public  void SetDisableCollision(bool bDisableCollision) {}
	///<summary>Retrieve the constraint force most recently applied to maintain this constraint. Returns 0 forces if the constraint is not initialized or broken.</summary>
	public  void GetConstraintForce(FVector OutLinearForce,FVector OutAngularForce) {}
	///<summary>Retrieve the status of constraint being broken.</summary>
	public  bool IsBroken() { return default; }
	///<summary>Gets the constraint object</summary>
	public  FConstraintInstanceAccessor GetConstraint() { return default; }
}
