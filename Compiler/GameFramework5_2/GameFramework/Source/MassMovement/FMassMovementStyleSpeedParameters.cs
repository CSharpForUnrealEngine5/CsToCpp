#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassMovementTypes.h")]
///<summary>Movement style consists of multiple speeds which are assigned to agents based on agents unique ID.</summary>
public partial struct FMassMovementStyleSpeedParameters {
// MassMovementStyleSpeedParameters
	public float Speed;
	public float Variance;
	public float Probability;
}
