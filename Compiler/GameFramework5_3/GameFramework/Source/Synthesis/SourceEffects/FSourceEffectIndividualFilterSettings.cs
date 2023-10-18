namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceEffects/SourceEffectMotionFilter.h")]
public partial struct FSourceEffectIndividualFilterSettings {
	public ESourceEffectMotionFilterCircuit FilterCircuit;
	public ESourceEffectMotionFilterType FilterType;
	public float CutoffFrequency;
	public float FilterQ;
}
