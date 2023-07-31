#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
public partial struct FNiagaraFunctionSignature {
	public string Name;
	public TArray<FNiagaraVariable> Inputs;
	public TArray<FNiagaraVariable> Outputs;
	public string OwnerName;
	public bool bRequiresContext;
	public bool bRequiresExecPin;
	public bool bMemberFunction;
	public bool bExperimental;
	public string ExperimentalMessage;
	public uint FunctionVersion;
	public bool bSupportsCPU;
	public bool bSupportsGPU;
	public bool bWriteFunction;
	public bool bReadFunction;
	public bool bSoftDeprecatedFunction;
	public bool bIsCompileTagGenerator;
	public bool bHidden;
	public int ModuleUsageBitmask;
	public int ContextStageIndex;
	public short RequiredInputs;
	public short RequiredOutputs;
	public TMap<string,string> FunctionSpecifiers;
	public string Description;
	public TMap<FNiagaraVariableBase,string> InputDescriptions;
	public TMap<FNiagaraVariableBase,string> OutputDescriptions;
}
