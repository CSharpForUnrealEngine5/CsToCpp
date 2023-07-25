#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraScriptVariable.h")]
public partial struct FNiagaraScriptVariableData {
// NiagaraScriptVariableData
	public ENiagaraDefaultMode DefaultMode;
	public FNiagaraScriptVariableBinding DefaultBinding;
	public FNiagaraVariable Variable;
	public FNiagaraVariableMetaData Metadata;
	public FNiagaraVariant DefaultValueVariant;
	public int StaticSwitchDefaultValue;
	public bool bIsStaticSwitch;
	public bool bSubscribedToParameterDefinitions;
	public FGuid ChangeId;
	public bool bOverrideParameterDefinitionsDefaultValue;
}
