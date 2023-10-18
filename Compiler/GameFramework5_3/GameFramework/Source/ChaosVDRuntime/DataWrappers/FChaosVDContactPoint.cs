namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataWrappers/ChaosVDCollisionDataWrappers.h")]
public partial struct FChaosVDContactPoint {
	public TArray<FVector> ShapeContactPoints;
	public FVector ShapeContactNormal;
	public float Phi;
	public int FaceIndex;
	public EChaosVDContactPointType ContactType;
}
