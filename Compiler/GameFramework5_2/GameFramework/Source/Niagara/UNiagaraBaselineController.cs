#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraPerfBaseline.h")]
///<summary>Base class for baseline controllers. These can are responsible for spawning and manipulating the FX needed for the baseline perf tests.</summary>
public partial class UNiagaraBaselineController : UObject {
// NiagaraBaselineController
	public void OnBeginTest() {}
	public bool OnTickTest() { return default; }
	public void OnEndTest(FNiagaraPerfBaselineStats Stats) {}
	public void OnOwnerTick(float DeltaTime) {}
	public UObject GetSystem() { return default; }
	public float TestDuration;
	public UNiagaraEffectType EffectType;
	public ANiagaraPerfBaselineActor Owner;
	public TSoftObjectPtr<UNiagaraSystem> System;
}
