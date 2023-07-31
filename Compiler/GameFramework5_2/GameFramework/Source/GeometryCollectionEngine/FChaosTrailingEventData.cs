#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A trailing event data structure.</summary>
[CppInclude("ChaosTrailingEventFilter.h")]
public partial struct FChaosTrailingEventData {
	public FVector Location;
	public FVector Velocity;
	public FVector AngularVelocity;
	public float Mass;
	public int ParticleIndex;
}
