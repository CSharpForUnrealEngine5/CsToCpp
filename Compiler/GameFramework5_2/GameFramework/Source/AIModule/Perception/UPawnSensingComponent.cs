#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SensingComponent encapsulates sensory (ie sight and hearing) settings and functionality for an Actor,</summary>
[CppInclude("Perception/PawnSensingComponent.h")]
public partial class UPawnSensingComponent : UActorComponent {
	///<summary>FSeePawnDelegate</summary>
	public  void FSeePawnDelegate(APawn Pawn) {}
	///<summary>FHearNoiseDelegate</summary>
	public  void FHearNoiseDelegate(APawn Instigator,FVector Location,float Volume) {}
	///<summary>Max distance at which a makenoise(1.0) loudness sound can be heard, regardless of occlusion</summary>
	public float HearingThreshold;
	///<summary>Max distance at which a makenoise(1.0) loudness sound can be heard if unoccluded (LOSHearingThreshold should be &gt; HearingThreshold)</summary>
	public float LOSHearingThreshold;
	///<summary>Maximum sight distance.</summary>
	public float SightRadius;
	///<summary>Amount of time between pawn sensing updates. Use SetSensingInterval() to adjust this at runtime. A value &lt;= 0 prevents any updates.</summary>
	public float SensingInterval;
	///<summary>Max age of sounds we can hear. Should be greater than SensingInterval, or you might miss hearing some sounds!</summary>
	public float HearingMaxSoundAge;
	///<summary>Changes the SensingInterval.</summary>
	public  void SetSensingInterval(float NewSensingInterval) {}
	///<summary>Enables or disables sensing updates. The timer is reset in either case.</summary>
	public  void SetSensingUpdatesEnabled(bool bEnabled) {}
	///<summary>Sets PeripheralVisionAngle. Calculates PeripheralVisionCosine from PeripheralVisionAngle</summary>
	public  void SetPeripheralVisionAngle(float NewPeripheralVisionAngle) {}
	///<summary>GetPeripheralVisionAngle</summary>
	public  float GetPeripheralVisionAngle() { return default; }
	///<summary>GetPeripheralVisionCosine</summary>
	public  float GetPeripheralVisionCosine() { return default; }
	///<summary>If true, component will perform sensing updates. At runtime change this using SetSensingUpdatesEnabled().</summary>
	public bool bEnableSensingUpdates;
	///<summary>If true, will only sense player-controlled pawns in the world. Default: true</summary>
	public bool bOnlySensePlayers;
	///<summary>If true, we will perform visibility tests and will trigger notifications when a Pawn is visible. Default: true</summary>
	public bool bSeePawns;
	///<summary>If true, we will perform audibility tests and will be notified when a Pawn makes a noise that can be heard. Default: true</summary>
	public bool bHearNoises;
	///<summary>Delegate to execute when we see a Pawn.</summary>
	public FSeePawnDelegate OnSeePawn;
	///<summary>Delegate to execute when we hear a noise from a Pawn&#39;s PawnNoiseEmitterComponent.</summary>
	public FHearNoiseDelegate OnHearNoise;
	///<summary>How far to the side AI can see, in degrees. Use SetPeripheralVisionAngle to change the value at runtime.</summary>
	public float PeripheralVisionAngle;
	///<summary>Cosine of limits of peripheral vision. Computed from PeripheralVisionAngle.</summary>
	public float PeripheralVisionCosine;
}
