#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/ConstraintInstance.h")]
///<summary>Container for properties of a physics constraint that can be easily swapped at runtime. This is useful for switching different setups when going from ragdoll to standup for example</summary>
public partial struct FConstraintProfileProperties {
// ConstraintProfileProperties
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
	public byte LinearPlasticityType;
}
