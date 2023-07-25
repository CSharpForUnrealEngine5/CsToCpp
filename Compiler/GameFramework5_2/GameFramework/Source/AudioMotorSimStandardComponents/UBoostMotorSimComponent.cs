#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoostMotorSimComponent.h")]
///<summary>Uses Boost input to momentarily scale throttle input and pitch output</summary>
public partial class UBoostMotorSimComponent : UAudioMotorSimComponent {
// BoostMotorSimComponent
	public float ThrottleScale;
	public float InterpExp;
	public float InterpTime;
	public bool ScaleThrottleWithBoostStrength;
	public bool bModifyPitch;
	public float PitchModifierInterpSpeed;
	public FRuntimeFloatCurve BoostToPitchCurve;
}
