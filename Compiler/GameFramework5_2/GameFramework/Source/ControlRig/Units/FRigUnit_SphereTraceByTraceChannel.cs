#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Collision/RigUnit_WorldCollision.h")]
///<summary>Sweeps a sphere against the world and return the first blocking hit using a specific channel. Target objects can have different object types, but they need to have the same trace channel set to "block" in their collision response settings.</summary>
public partial struct FRigUnit_SphereTraceByTraceChannel {
// RigUnit_SphereTraceByTraceChannel
	public FVector Start;
	public FVector End;
	public byte TraceChannel;
	public float Radius;
	public bool bHit;
	public FVector HitLocation;
	public FVector HitNormal;
}
