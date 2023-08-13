namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movement style consists of multiple speeds which are assigned to agents based on agents unique ID.</summary>
[CppInclude("MassMovementTypes.h")]
public partial struct FMassMovementStyleSpeedParameters {
	public float Speed;
	public float Variance;
	public float Probability;
}
