#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/PawnSensingComponent.h")]
///<summary>SensingComponent encapsulates sensory (ie sight and hearing) settings and functionality for an Actor,</summary>
public partial class UPawnSensingComponent : UActorComponent {
// PawnSensingComponent
	public  void FSeePawnDelegate(APawn Pawn) {}
	public  void FHearNoiseDelegate(APawn Instigator,FVector Location,float Volume) {}
	public float HearingThreshold;
	public float LOSHearingThreshold;
	public float SightRadius;
	public float SensingInterval;
	public float HearingMaxSoundAge;
	public  void SetSensingInterval(float NewSensingInterval) {}
	public  void SetSensingUpdatesEnabled(bool bEnabled) {}
	public  void SetPeripheralVisionAngle(float NewPeripheralVisionAngle) {}
	public  float GetPeripheralVisionAngle() { return default; }
	public  float GetPeripheralVisionCosine() { return default; }
	public bool bEnableSensingUpdates;
	public bool bOnlySensePlayers;
	public bool bSeePawns;
	public bool bHearNoises;
	public FSeePawnDelegate OnSeePawn;
	public FHearNoiseDelegate OnHearNoise;
	public float PeripheralVisionAngle;
	public float PeripheralVisionCosine;
}
