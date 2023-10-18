namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
public partial struct FNiagaraFunctionSignature {
	public FName Name;
	public TArray<FNiagaraVariable> Inputs;
	public TArray<FNiagaraVariable> Outputs;
	public FName OwnerName;
	public bool bRequiresContext;
	public bool bRequiresExecPin;
	public bool bMemberFunction;
	public bool bExperimental;
	public FText ExperimentalMessage;
	public uint FunctionVersion;
	public bool bSupportsCPU;
	public bool bSupportsGPU;
	public bool bWriteFunction;
	public bool bReadFunction;
	public bool bSoftDeprecatedFunction;
	public bool bIsCompileTagGenerator;
	public bool bHidden;
	public int ModuleUsageBitmask;
	public ushort MiscUsageBitMask;
	public int ContextStageIndex;
	public short RequiredInputs;
	public short RequiredOutputs;
	public TMap<FName,FName> FunctionSpecifiers;
	public FText Description;
	public TMap<FNiagaraVariableBase,FText> InputDescriptions;
	public TMap<FNiagaraVariableBase,FText> OutputDescriptions;
}
