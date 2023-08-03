#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>PawnNoiseEmitterComponent tracks noise event data used by SensingComponents to hear a Pawn.</summary>
[CppInclude("Components/PawnNoiseEmitterComponent.h")]
public partial class UPawnNoiseEmitterComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>If set to true (default value) will notify AIPerceptionSystem about noise events</summary>
	public bool bAIPerceptionSystemCompatibilityMode;
	///<summary>Most recent noise made by this pawn not at its own location</summary>
	public FVector LastRemoteNoisePosition;
	///<summary>After this amount of time, new sound events will overwrite previous sounds even if they are not louder (allows old sounds to decay)</summary>
	public float NoiseLifetime;
	///<summary>Cache noises instigated by the owning pawn for AI sensing</summary>
	public  void MakeNoise(AActor NoiseMaker,float Loudness,FVector NoiseLocation) {}
	///<summary>Most recent volume of noise made by this pawn not at its own location</summary>
	public float LastRemoteNoiseVolume;
	///<summary>Time of last remote noise update</summary>
	public float LastRemoteNoiseTime;
	///<summary>Most recent noise made by this pawn at its own location</summary>
	public float LastLocalNoiseVolume;
	///<summary>Time of last local noise update</summary>
	public float LastLocalNoiseTime;
}
