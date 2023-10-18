namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Vehicle inputs from the player controller</summary>
[CppInclude("ChaosVehicleManagerAsyncCallback.h")]
public partial struct FVehicleInputs {
	public float SteeringInput;
	public float ThrottleInput;
	public float BrakeInput;
	public float PitchInput;
	public float RollInput;
	public float YawInput;
	public float HandbrakeInput;
}
