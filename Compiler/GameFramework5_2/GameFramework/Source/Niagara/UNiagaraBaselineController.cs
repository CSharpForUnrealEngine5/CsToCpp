namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for baseline controllers. These can are responsible for spawning and manipulating the FX needed for the baseline perf tests.</summary>
[CppInclude("NiagaraPerfBaseline.h")]
public partial class UNiagaraBaselineController : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Called from the stats system when we begin gathering stats for the given System asset.</summary>
	public void OnBeginTest() {}
	///<summary>Returns whether the baseline test is complete.</summary>
	public bool OnTickTest() { return default; }
	///<summary>Called from the stats system on completion of the test with the final stats for the given system asset.</summary>
	public void OnEndTest(FNiagaraPerfBaselineStats Stats) {}
	///<summary>Called when the owning actor is ticked.</summary>
	public void OnOwnerTick(float DeltaTime) {}
	///<summary>Returns the System for this baseline. Will synchronously load the system if needed.</summary>
	public UNiagaraSystem GetSystem() { return default; }
	///<summary>Duration to gather performance stats for the given system.</summary>
	public float TestDuration;
	///<summary>The effect type this controller is in use by.</summary>
	public UNiagaraEffectType EffectType;
	///<summary>The owning actor for this baseline controller.</summary>
	public ANiagaraPerfBaselineActor Owner;
	///<summary>The baseline system to spawn.</summary>
	public TSoftObjectPtr<UNiagaraSystem> System;
}
