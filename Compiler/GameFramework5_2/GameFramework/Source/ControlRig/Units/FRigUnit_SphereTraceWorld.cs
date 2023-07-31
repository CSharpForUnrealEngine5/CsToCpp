#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sweeps a sphere against the world and return the first blocking hit using a specific channel</summary>
[CppInclude("Units/Collision/RigUnit_WorldCollision.h")]
public partial struct FRigUnit_SphereTraceWorld {
	public FVector Start;
	public FVector End;
	public ECollisionChannel Channel;
	public float Radius;
	public bool bHit;
	public FVector HitLocation;
	public FVector HitNormal;
}
