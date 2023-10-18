namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A breaking event data structure.</summary>
[CppInclude("ChaosBreakingEventFilter.h")]
public partial struct FChaosBreakingEventData {
	public FVector Location;
	public FVector Velocity;
	public float Mass;
}
