namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
///<summary>Defines different usages for a niagara script.</summary>
public enum ENiagaraScriptUsage {
	Function=0,
	Module=1,
	DynamicInput=2,
	ParticleSpawnScript=3,
	ParticleSpawnScriptInterpolated=4,
	ParticleUpdateScript=5,
	ParticleEventScript=6,
	ParticleSimulationStageScript=7,
	ParticleGPUComputeScript=8,
	EmitterSpawnScript=9,
	EmitterUpdateScript=10,
	SystemSpawnScript=11,
	SystemUpdateScript=12,
}
