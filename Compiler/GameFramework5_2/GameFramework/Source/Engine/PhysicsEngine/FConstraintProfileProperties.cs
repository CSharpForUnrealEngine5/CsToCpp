#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container for properties of a physics constraint that can be easily swapped at runtime. This is useful for switching different setups when going from ragdoll to standup for example</summary>
[CppInclude("PhysicsEngine/ConstraintInstance.h")]
public partial struct FConstraintProfileProperties {
	public float ProjectionLinearTolerance;
	public float ProjectionAngularTolerance;
	public float ProjectionLinearAlpha;
	public float ProjectionAngularAlpha;
	public float ShockPropagationAlpha;
	public float LinearBreakThreshold;
	public float LinearPlasticityThreshold;
	public float AngularBreakThreshold;
	public float AngularPlasticityThreshold;
	public float ContactTransferScale;
	public FLinearConstraint LinearLimit;
	public FConeConstraint ConeLimit;
	public FTwistConstraint TwistLimit;
	public bool bDisableCollision;
	public bool bParentDominates;
	public bool bEnableShockPropagation;
	public bool bEnableProjection;
	public bool bEnableMassConditioning;
	public bool bAngularBreakable;
	public bool bAngularPlasticity;
	public bool bLinearBreakable;
	public bool bLinearPlasticity;
	public FLinearDriveConstraint LinearDrive;
	public FAngularDriveConstraint AngularDrive;
	public EConstraintPlasticityType LinearPlasticityType;
}
