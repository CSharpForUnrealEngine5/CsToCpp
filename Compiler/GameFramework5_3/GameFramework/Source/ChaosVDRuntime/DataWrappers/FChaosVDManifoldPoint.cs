namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataWrappers/ChaosVDCollisionDataWrappers.h")]
public partial struct FChaosVDManifoldPoint {
	public bool bDisabled;
	public bool bWasRestored;
	public bool bWasReplaced;
	public bool bHasStaticFrictionAnchor;
	public bool bIsValid;
	public bool bInsideStaticFrictionCone;
	public FVector NetPushOut;
	public FVector NetImpulse;
	public float TargetPhi;
	public TArray<FVector> ShapeAnchorPoints;
	public TArray<FVector> InitialShapeContactPoints;
	public FChaosVDContactPoint ContactPoint;
	public TArray<FVector> ShapeContactPoints;
}
