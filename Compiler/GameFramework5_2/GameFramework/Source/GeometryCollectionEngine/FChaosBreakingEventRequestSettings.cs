#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosBreakingEventFilter.h")]
///<summary>Settings used to refine breaking event requests</summary>
public partial struct FChaosBreakingEventRequestSettings {
// ChaosBreakingEventRequestSettings
	public int MaxNumberOfResults;
	public float MinRadius;
	public float MinSpeed;
	public float MinMass;
	public float MaxDistance;
	public EChaosBreakingSortMethod SortMethod;
}
