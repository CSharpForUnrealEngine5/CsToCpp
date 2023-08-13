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
