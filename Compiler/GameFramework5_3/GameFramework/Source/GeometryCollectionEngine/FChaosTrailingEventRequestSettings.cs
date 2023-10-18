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
