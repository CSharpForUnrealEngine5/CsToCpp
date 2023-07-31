#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Removal event data structure.</summary>
[CppInclude("ChaosRemovalEventFilter.h")]
public partial struct FChaosRemovalEventData {
	public FVector Location;
	public float Mass;
	public int ParticleIndex;
}
