#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FSourceEffectMotionFilterSettings</summary>
[CppInclude("SourceEffects/SourceEffectMotionFilter.h")]
public partial struct FSourceEffectMotionFilterSettings {
	public ESourceEffectMotionFilterTopology MotionFilterTopology;
	public float MotionFilterMix;
	public FSourceEffectIndividualFilterSettings FilterASettings;
	public FSourceEffectIndividualFilterSettings FilterBSettings;
	public TMap<ESourceEffectMotionFilterModDestination,FSourceEffectMotionFilterModulationSettings> ModulationMappings;
	public float DryVolumeDb;
}
