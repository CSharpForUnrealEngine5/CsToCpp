#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosCollisionEventFilter.h")]
///<summary>Settings used to define collision event requests</summary>
public partial struct FChaosCollisionEventRequestSettings {
// ChaosCollisionEventRequestSettings
	public int MaxNumberResults;
	public float MinMass;
	public float MinSpeed;
	public float MinImpulse;
	public float MaxDistance;
	public EChaosCollisionSortMethod SortMethod;
}
