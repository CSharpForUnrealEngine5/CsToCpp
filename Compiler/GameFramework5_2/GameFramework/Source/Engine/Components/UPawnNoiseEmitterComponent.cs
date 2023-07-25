#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/PawnNoiseEmitterComponent.h")]
///<summary>PawnNoiseEmitterComponent tracks noise event data used by SensingComponents to hear a Pawn.</summary>
public partial class UPawnNoiseEmitterComponent : UActorComponent {
// PawnNoiseEmitterComponent
	public bool bAIPerceptionSystemCompatibilityMode;
	public FVector LastRemoteNoisePosition;
	public float NoiseLifetime;
	public void MakeNoise(UObject NoiseMaker,float Loudness,FVector NoiseLocation) {}
	public float LastRemoteNoiseVolume;
	public float LastRemoteNoiseTime;
	public float LastLocalNoiseVolume;
	public float LastLocalNoiseTime;
}
