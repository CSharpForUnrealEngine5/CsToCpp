namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sweeps a sphere against the world and return the first blocking hit. The trace is filtered by object types only, the collision response settings are ignored.</summary>
[CppInclude("Units/Collision/RigUnit_WorldCollision.h")]
public partial struct FRigUnit_SphereTraceByObjectTypes {
	public FVector Start;
	public FVector End;
	public TArray<EObjectTypeQuery> ObjectTypes;
	public float Radius;
	public bool bHit;
	public FVector HitLocation;
	public FVector HitNormal;
}
