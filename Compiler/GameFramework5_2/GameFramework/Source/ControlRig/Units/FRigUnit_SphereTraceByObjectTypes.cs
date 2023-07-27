#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Collision/RigUnit_WorldCollision.h")]
///<summary>Sweeps a sphere against the world and return the first blocking hit. The trace is filtered by object types only, the collision response settings are ignored.</summary>
public partial struct FRigUnit_SphereTraceByObjectTypes {
// RigUnit_SphereTraceByObjectTypes
	public FVector Start;
	public FVector End;
	public TArray<EObjectTypeQuery> ObjectTypes;
	public float Radius;
	public bool bHit;
	public FVector HitLocation;
	public FVector HitNormal;
}
