#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceEffects/SourceEffectMotionFilter.h")]
///<summary>FSourceEffectMotionFilterSettings</summary>
public partial struct FSourceEffectMotionFilterSettings {
// SourceEffectMotionFilterSettings
	public ESourceEffectMotionFilterTopology MotionFilterTopology;
	public float MotionFilterMix;
	public FSourceEffectIndividualFilterSettings FilterASettings;
	public FSourceEffectIndividualFilterSettings FilterBSettings;
	public TMap<ESourceEffectMotionFilterModDestination,FSourceEffectMotionFilterModulationSettings> ModulationMappings;
	public float DryVolumeDb;
}
