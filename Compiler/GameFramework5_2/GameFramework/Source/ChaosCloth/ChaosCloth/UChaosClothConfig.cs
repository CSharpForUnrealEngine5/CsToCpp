#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosCloth/ChaosClothConfig.h")]
///<summary>Holds initial, asset level config for clothing actors. // Hiding categories that will be used in the future</summary>
public partial class UChaosClothConfig : UClothConfigCommon {
// ChaosClothConfig
	public EClothMassMode MassMode;
	public float UniformMass;
	public float TotalMass;
	public float Density;
	public float MinPerParticleMass;
	public FChaosClothWeightedValue EdgeStiffnessWeighted;
	public FChaosClothWeightedValue BendingStiffnessWeighted;
	public bool bUseBendingElements;
	public float BucklingRatio;
	public FChaosClothWeightedValue BucklingStiffnessWeighted;
	public FChaosClothWeightedValue AreaStiffnessWeighted;
	public float VolumeStiffness;
	public FChaosClothWeightedValue TetherStiffness;
	public FChaosClothWeightedValue TetherScale;
	public bool bUseGeodesicDistance;
	public float ShapeTargetStiffness;
	public float CollisionThickness;
	public float FrictionCoefficient;
	public bool bUseCCD;
	public bool bUseSelfCollisions;
	public float SelfCollisionThickness;
	public float SelfCollisionFriction;
	public bool bUseSelfIntersections;
	public bool bUseLegacyBackstop;
	public float DampingCoefficient;
	public float LocalDampingCoefficient;
	public bool bUsePointBasedWindModel;
	public FChaosClothWeightedValue Drag;
	public FChaosClothWeightedValue Lift;
	public bool bUseGravityOverride;
	public float GravityScale;
	public FVector Gravity;
	public FChaosClothWeightedValue Pressure;
	public FChaosClothWeightedValue AnimDriveStiffness;
	public FChaosClothWeightedValue AnimDriveDamping;
	public FVector LinearVelocityScale;
	public float AngularVelocityScale;
	public float FictitiousAngularScale;
	public bool bUseTetrahedralConstraints;
	public bool bUseThinShellVolumeConstraints;
	public bool bUseContinuousCollisionDetection;
	public float EdgeStiffness_DEPRECATED;
	public float BendingStiffness_DEPRECATED;
	public float AreaStiffness_DEPRECATED;
	public EChaosClothTetherMode TetherMode_DEPRECATED;
	public float LimitScale_DEPRECATED;
	public float DragCoefficient_DEPRECATED;
	public float LiftCoefficient_DEPRECATED;
	public float AnimDriveSpringStiffness_DEPRECATED;
	public float StrainLimitingStiffness_DEPRECATED;
}
