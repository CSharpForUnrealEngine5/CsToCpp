#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCollection/RecordedTransformTrack.h")]
public partial struct FSolverCollisionData {
	public FVector Location;
	public FVector AccumulatedImpulse;
	public FVector Normal;
	public FVector Velocity1;
	public FVector Velocity2;
	public FVector AngularVelocity1;
	public FVector AngularVelocity2;
	public float Mass1;
	public float Mass2;
	public int ParticleIndex;
	public int LevelsetIndex;
	public int ParticleIndexMesh;
	public int LevelsetIndexMesh;
}
