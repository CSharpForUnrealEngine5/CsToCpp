#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNotifyState_TimedNiagaraEffect.h")]
///<summary>Same as Timed Niagara Effect but also provides some more advanced abilities at an additional cost.</summary>
public partial class UAnimNotifyState_TimedNiagaraEffectAdvanced : UAnimNotifyState_TimedNiagaraEffect {
// AnimNotifyState_TimedNiagaraEffectAdvanced
	public float GetNotifyProgress(UObject MeshComp) { return default; }
	public bool bEnableNormalizedNotifyProgress;
	public string NotifyProgressUserParameter;
	public TArray<FCurveParameterPair> AnimCurves;
}
