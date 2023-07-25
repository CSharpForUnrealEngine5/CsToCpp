#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Parameter/ParticleModuleParameterDynamic.h")]
///<summary>Helper structure for displaying the parameter.</summary>
public partial struct FEmitterDynamicParameter {
// EmitterDynamicParameter
	public string ParamName;
	public bool bUseEmitterTime;
	public bool bSpawnTimeOnly;
	public byte ValueMethod;
	public bool bScaleVelocityByParamValue;
	public FRawDistributionFloat ParamValue;
}
