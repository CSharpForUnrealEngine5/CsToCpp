namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>BlueprintType wrapper around FEmitterDynamicParameter to allow managing in blueprint/python logic.</summary>
[CppInclude("NiagaraStackGraphUtilitiesAdapterLibrary.h")]
public partial struct FEmitterDynamicParameterBP {
	public FName ParamName;
	public bool bUseEmitterTime;
	public bool bSpawnTimeOnly;
	public EEmitterDynamicParameterValue ValueMethod;
	public bool bScaleVelocityByParamValue;
	public FRawDistributionFloat ParamValue;
}
