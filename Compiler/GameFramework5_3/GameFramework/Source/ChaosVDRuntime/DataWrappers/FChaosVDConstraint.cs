namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataWrappers/ChaosVDCollisionDataWrappers.h")]
public partial struct FChaosVDConstraint {
	public bool bDisabled;
	public bool bUseManifold;
	public bool bUseIncrementalManifold;
	public bool bCanRestoreManifold;
	public bool bWasManifoldRestored;
	public bool bIsQuadratic0;
	public bool bIsQuadratic1;
	public bool bIsProbeUnmodified;
	public bool bIsProbe;
	public bool bCCDEnabled;
	public bool bCCDSweepEnabled;
	public bool bModifierApplied;
	public bool bMaterialSet;
	public FVector AccumulatedImpulse;
	public EChaosVDContactShapesType ShapesType;
	public TArray<FTransform> ShapeWorldTransforms;
	public TArray<FTransform> ImplicitTransforms;
	public float CullDistance;
	public TArray<float> CollisionMargins;
	public float CollisionTolerance;
	public int ClosestManifoldPointIndex;
	public int ExpectedNumManifoldPoints;
	public FVector LastShapeWorldPositionDelta;
	public FQuat LastShapeWorldRotationDelta;
	public float Stiffness;
	public float CCDTimeOfImpact;
	public float CCDEnablePenetration;
	public float CCDTargetPenetration;
	public TArray<FChaosVDManifoldPoint> ManifoldPoints;
	public int Particle0Index;
	public int Particle1Index;
}
