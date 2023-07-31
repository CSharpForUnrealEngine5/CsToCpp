#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sweeps a sphere against the world and return the first blocking hit using a specific channel. Target objects can have different object types, but they need to have the same trace channel set to &quot;block&quot; in their collision response settings.</summary>
[CppInclude("Units/Collision/RigUnit_WorldCollision.h")]
public partial struct FRigUnit_SphereTraceByTraceChannel {
	public FVector Start;
	public FVector End;
	public ETraceTypeQuery TraceChannel;
	public float Radius;
	public bool bHit;
	public FVector HitLocation;
	public FVector HitNormal;
}
