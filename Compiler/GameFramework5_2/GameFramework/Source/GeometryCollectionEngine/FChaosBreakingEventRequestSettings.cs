namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings used to refine breaking event requests</summary>
[CppInclude("ChaosBreakingEventFilter.h")]
public partial struct FChaosBreakingEventRequestSettings {
	public int MaxNumberOfResults;
	public float MinRadius;
	public float MinSpeed;
	public float MinMass;
	public float MaxDistance;
	public EChaosBreakingSortMethod SortMethod;
}
