namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceEffects/SourceEffectMotionFilter.h")]
public partial struct FSourceEffectMotionFilterModulationSettings {
	public ESourceEffectMotionFilterModSource ModulationSource;
	public FVector2D ModulationInputRange;
	public FVector2D ModulationOutputMinimumRange;
	public FVector2D ModulationOutputMaximumRange;
	public float UpdateEaseMS;
}
