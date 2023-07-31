#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassMovementFragments.h")]
public partial struct FMassMovementParameters {
	public float MaxSpeed;
	public float MaxAcceleration;
	public float DefaultDesiredSpeed;
	public float DefaultDesiredSpeedVariance;
	public float HeightSmoothingTime;
	public TArray<FMassMovementStyleParameters> MovementStyles;
}
