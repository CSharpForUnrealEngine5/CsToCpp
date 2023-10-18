namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Removal event data structure.</summary>
[CppInclude("ChaosRemovalEventFilter.h")]
public partial struct FChaosRemovalEventData {
	public FVector Location;
	public float Mass;
	public int ParticleIndex;
}
