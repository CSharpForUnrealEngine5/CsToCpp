namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Same as Timed Niagara Effect but also provides some more advanced abilities at an additional cost.</summary>
[CppInclude("AnimNotifyState_TimedNiagaraEffect.h")]
public partial class UAnimNotifyState_TimedNiagaraEffectAdvanced : UAnimNotifyState_TimedNiagaraEffect {
	public static UClass StaticClass() {return default;}
	///<summary>Returns a 0 to 1 value for the progress of this component along the notify.</summary>
	public float GetNotifyProgress(UMeshComponent MeshComp) { return default; }
	///<summary>This send a 0-1 value of the normalized progress to the FX Component to the float User Parameter.</summary>
	public bool bEnableNormalizedNotifyProgress;
	///<summary>The name of your niagara user variable you would like to send the normalized notify progress to.</summary>
	public string NotifyProgressUserParameter;
	///<summary>Array of fnames to map Anim Curve names to Niagara Parameters.</summary>
	public TArray<FCurveParameterPair> AnimCurves;
}
