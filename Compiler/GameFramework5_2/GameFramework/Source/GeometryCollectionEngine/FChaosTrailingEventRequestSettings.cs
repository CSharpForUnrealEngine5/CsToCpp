#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosTrailingEventFilter.h")]
public partial struct FChaosTrailingEventRequestSettings {
	public int MaxNumberOfResults;
	public float MinMass;
	public float MinSpeed;
	public float MinAngularSpeed;
	public float MaxDistance;
	public EChaosTrailingSortMethod SortMethod;
}
