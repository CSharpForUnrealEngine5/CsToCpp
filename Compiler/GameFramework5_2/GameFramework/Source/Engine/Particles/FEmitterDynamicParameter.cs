namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper structure for displaying the parameter.</summary>
[CppInclude("Particles/Parameter/ParticleModuleParameterDynamic.h")]
public partial struct FEmitterDynamicParameter {
	public string ParamName;
	public bool bUseEmitterTime;
	public bool bSpawnTimeOnly;
	public EEmitterDynamicParameterValue ValueMethod;
	public bool bScaleVelocityByParamValue;
	public FRawDistributionFloat ParamValue;
}
