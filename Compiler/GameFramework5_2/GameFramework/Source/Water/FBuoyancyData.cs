#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BuoyancyTypes.h")]
public partial struct FBuoyancyData {
	public TArray<FSphericalPontoon> Pontoons;
	public bool bCenterPontoonsOnCOM;
	public float BuoyancyCoefficient;
	public float BuoyancyDamp;
	public float BuoyancyDamp2;
	public float BuoyancyRampMinVelocity;
	public float BuoyancyRampMaxVelocity;
	public float BuoyancyRampMax;
	public float MaxBuoyantForce;
	public bool bApplyDragForcesInWater;
	public float DragCoefficient;
	public float DragCoefficient2;
	public float AngularDragCoefficient;
	public float MaxDragSpeed;
	public bool bApplyRiverForces;
	public int RiverPontoonIndex;
	public float WaterShorePushFactor;
	public float RiverTraversalPathWidth;
	public float MaxShorePushForce;
	public float WaterVelocityStrength;
	public float MaxWaterForce;
	public bool bAlwaysAllowLateralPush;
	public bool bAllowCurrentWhenMovingFastUpstream;
	public bool bApplyDownstreamAngularRotation;
	public FVector DownstreamAxisOfRotation;
	public float DownstreamRotationStrength;
	public float DownstreamRotationStiffness;
	public float DownstreamRotationAngularDamping;
	public float DownstreamMaxAcceleration;
}
