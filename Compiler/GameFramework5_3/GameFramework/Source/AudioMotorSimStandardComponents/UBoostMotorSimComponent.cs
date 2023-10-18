namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Uses Boost input to momentarily scale throttle input and pitch output</summary>
[CppInclude("BoostMotorSimComponent.h")]
public partial class UBoostMotorSimComponent : UAudioMotorSimComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Scale the engine torque by this value when boost is active</summary>
	public float ThrottleScale;
	///<summary>controls shape of the scaling</summary>
	public float InterpExp;
	///<summary>How fast the torque scales when starting to boost</summary>
	public float InterpTime;
	///<summary>whether to use the boost strength to scale ThrottleScale, or just check if it is &gt; 0 to apply the throttle scalar</summary>
	public bool ScaleThrottleWithBoostStrength;
	///<summary>whether scale the overall pitch by the boost strength</summary>
	public bool bModifyPitch;
	///<summary>Speed at which pitch approaches its target value</summary>
	public float PitchModifierInterpSpeed;
	///<summary>Curve to derive final pitch value (in playback speed) from boost strength</summary>
	public FRuntimeFloatCurve BoostToPitchCurve;
}
