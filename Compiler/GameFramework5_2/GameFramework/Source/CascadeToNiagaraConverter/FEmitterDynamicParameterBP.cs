#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraStackGraphUtilitiesAdapterLibrary.h")]
///<summary>BlueprintType wrapper around FEmitterDynamicParameter to allow managing in blueprint/python logic.</summary>
public partial struct FEmitterDynamicParameterBP {
// EmitterDynamicParameterBP
	public string ParamName;
	public bool bUseEmitterTime;
	public bool bSpawnTimeOnly;
	public EEmitterDynamicParameterValue ValueMethod;
	public bool bScaleVelocityByParamValue;
	public FRawDistributionFloat ParamValue;
}
