namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaveformTransformationEffectChain.h")]
public partial class UWaveformTransformationEffectChain : UWaveformTransformationBase {
	public static UClass StaticClass() {return default;}
	///<summary>EffectChain</summary>
	public USoundEffectSourcePresetChain EffectChain;
	///<summary>InlineEffects</summary>
	public TArray<USoundEffectSourcePreset> InlineEffects;
}
