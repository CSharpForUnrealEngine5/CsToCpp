namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings used to define collision event requests</summary>
[CppInclude("ChaosCollisionEventFilter.h")]
public partial struct FChaosCollisionEventRequestSettings {
	public int MaxNumberResults;
	public float MinMass;
	public float MinSpeed;
	public float MinImpulse;
	public float MaxDistance;
	public EChaosCollisionSortMethod SortMethod;
}
